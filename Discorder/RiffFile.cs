using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Discorder.RIFF
{


    public class WaveFile
    {
        private string _filePath;

        public RiffFile(string filePath)
        {
            this._filePath = filePath;
        }
    }


    public class Chunk
    {
        private int _startOffset;
        private int _length;
        private string _filePath;

        public Chunk(string filePath, int startOffset, int length)
        {
            this._filePath = filePath;
            this._startOffset = startOffset;
            this._length = length;
        }

        private byte[] GetByteArrayFromFile(int start, int length)
        {
            using (FileStream fs = new FileStream(this._filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                byte[] ba = new byte[length];
                fs.Seek(start, SeekOrigin.Begin); //moves to the startOffset point
                fs.Read(ba, 0, length);
                return ba;
            }
        }


        public byte[] ChunkID_ba
        {
            get
            {
                return GetByteArray(this._startOffset, 4);
            }
        }

        public string ChunkID
        {
            get
            {
                return System.Text.Encoding.ASCII.GetString(this.ChunkID_ba);
            }
        }


        //returns the chunk size block
        public byte[] ChunkSize_ba
        {
            get
            {
                return GetByteArray(this._startOffset + 4, 4);
            }
        }

        /// <summary>
        /// Converts the Chunk size to an integer
        /// </summary>
        public int ChunkSize
        {
            get
            {
                return System.BitConverter.ToInt32(this.ChunkSize_ba, 0);
            }
        }


        public byte[] ChunkData_ba
        {
            get
            {
                return GetByteArray(this._startOffset + 8, this.ChunkSize - 4);
            }
        }



        public static List<Chunk> GetChunks(string fileName, int start, int length)
        {
            throw new NotImplementedException();
            return null;
        }

    }



}

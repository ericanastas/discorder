using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Discorder.RIFF
{
    class RiffFile
    {
        private string _filePath;
        public RiffHeader Header
        {
            get;
            private set;
        }

        public RiffFile(string filePath)
        {
            this._filePath = filePath;
            this.Header = new RiffHeader(filePath);
        }

        public List<Chunk> Chunks
        {
            get
            {
                //gets the chunks from the data after the header
                //the header is 12 bytes long, but the FileLength
                //specified in the header includes the last 4 bytes of the FileType
                return Chunk.GetChunks(this._filePath, 12, this.Header.FileLength - 4);
            }
        }
    }

    public class RiffHeader
    {
        private string _filePath;
        public RiffHeader(string filePath)
        {
            this._filePath = filePath;
        }

        public byte[] GroupID_ba
        {
            get
            {
                using (FileStream fs = new FileStream(this._filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    byte[] ba = new byte[4];
                    fs.Read(ba, 0, 4); //reads the first four bytes
                    return ba;
                }
            }
        }

        public String GroupID
        {
            get
            {
                return System.Text.Encoding.ASCII.GetString(this.GroupID_ba);
            }
        }

        public byte[] FileLength_ba
        {
            get
            {
                using (FileStream fs = new FileStream(this._filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    byte[] ba = new byte[4];
                    fs.Seek(4, SeekOrigin.Begin); //moves to the 5th byte
                    fs.Read(ba, 0, 4);
                    return ba;
                }
            }
        }

        public int FileLength
        {
            get
            {
                return System.BitConverter.ToInt32(FileLength_ba, 0);
            }
        }
        public byte[] Type_ba
        {
            get
            {
                using (FileStream fs = new FileStream(this._filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    byte[] ba = new byte[4];
                    fs.Seek(8, SeekOrigin.Begin); //moves to the 9th byte
                    fs.Read(ba, 0, 4);
                    return ba;
                }
            }
        }

        public string Type
        {
            get
            {
                return System.Text.Encoding.ASCII.GetString(this.Type_ba);
            }

        }
    }


    public class Chunk
    {
        private int _start;
        private int _end;
        private string _filePath;

        public Chunk(string filePath, int start, int end)
        {
            this._filePath = filePath;
            this._start = start;
            this._end = end;
        }

        private byte[] GetByteArray(int start, int length)
        {
            using (FileStream fs = new FileStream(this._filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                byte[] ba = new byte[length];
                fs.Seek(start, SeekOrigin.Begin); //moves to the start point
                fs.Read(ba, 0, length);
                return ba;
            }
        }


        public byte[] ChunkID_ba
        {
            get
            {
                return GetByteArray(this._start, 4);
            }
        }

        public string ChunkID
        {
            get
            {
                return System.Text.Encoding.ASCII.GetString(this.ChunkID_ba);
            }
        }

        public byte[] ChunkSize_ba
        {
            get
            {
                return GetByteArray(this._start + 4, 4);
            }
        }

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
                return GetByteArray(this._start + 8, this.ChunkSize - 4);
            }
        }

        public static List<Chunk> GetChunks(string fileName, long start, long end)
        {
            int currentChunkStart;
            List<Chunk> chunks = new List<Chunk>();
            bool notAtEnd = false;

            return null;
        }

    }



}

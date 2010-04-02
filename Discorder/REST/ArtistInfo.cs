using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Discorder.REST
{
    [System.SerializableAttribute()]
    public class ArtistInfo
    {

        private string nameField;

        private string anvField;

        private string roleField;

        private string tracksField;

        private string joinField;


        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }


        public string anv
        {
            get
            {
                return this.anvField;
            }
            set
            {
                this.anvField = value;
            }
        }


        public string role
        {
            get
            {
                return this.roleField;
            }
            set
            {
                this.roleField = value;
            }
        }


        public string tracks
        {
            get
            {
                return this.tracksField;
            }
            set
            {
                this.tracksField = value;
            }
        }

        public string join
        {
            get
            {
                return this.joinField;
            }
            set
            {
                this.joinField = value;
            }
        }
    }
}

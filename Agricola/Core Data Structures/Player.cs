using System;
using System.Collections.Generic;
using System.Text;

namespace agricola
{
    public class Player : IResourceContainer
    {
        private List<MajorImprovement> majorImprovements;
    
        public Player( string Name )
        {
            throw new System.NotImplementedException();
        }

        public Player( string Name, bool StartofGame )
        {
            throw new System.NotImplementedException();
        }

        public int FamilyMembers
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Board Board
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public string Name
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        #region IResourceContainer Members

        public int Cattle
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public int Clay
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public int Food
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public int Grain
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public int Reed
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public int Sheep
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public int Stone
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public int Vegetables
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public int WildBoar
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public int Wood
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        #endregion

        public List<MajorImprovement> MajorImprovements
        {
            get
            {
                return majorImprovements;
            }
            set
            {
                this.majorImprovements = value;
            }
        }
    }
}

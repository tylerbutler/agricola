﻿using System;
using System.Collections.Generic;
using System.Text;

namespace agricola
{
    public class Player
    {
        private List<MajorImprovement> majorImprovements;
        private Dictionary<AllResources, int> resources;
        private List<FamilyMember> familyMembers;
        public List<FamilyMember> FamilyMembers
        {
            get
            {
                return familyMembers;
            }
            set
            {
                familyMembers = value;
            }
        }

        public Dictionary<AllResources, int> Resources
        {
            get
            {
                return resources;
            }
            set
            {
                resources = value;
            }
        }

        public Player( string Name )
        {
            this.Name = Name;
            foreach( AllResources resource in Enum.GetValues( typeof( AllResources ) ) )
            {
                this.Resources.Add( resource, 0 );
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

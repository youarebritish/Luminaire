using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Data.Wind
{
    public partial class BonamikWindPresetEntity : SQEX.Ebony.Framework.Entity.Entity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool isEnable_;
		public uint bnmwnd0Id;
		public string bnmwnd0Path;
		public uint bnmwnd1Id;
		public string bnmwnd1Path;
		public uint bnmwnd2Id;
		public string bnmwnd2Path;
		public uint bnmwnd3Id;
		public string bnmwnd3Path;
		public uint bnmwnd4Id;
		public string bnmwnd4Path;
		public uint bnmwnd5Id;
		public string bnmwnd5Path;
		public uint bnmwnd6Id;
		public string bnmwnd6Path;
		public uint bnmwnd7Id;
		public string bnmwnd7Path;
		public uint bnmwnd8Id;
		public string bnmwnd8Path;
		public uint bnmwnd9Id;
		public string bnmwnd9Path;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new BonamikWindPresetEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Data.Wind.BonamikWindPresetEntity", 0, Black.Entity.Data.Wind.BonamikWindPresetEntity.ObjectType, null, properties, 0, 464);
        }
		
        public override ObjectType GetObjectType()
        {
            return ObjectType;
        }

        protected override PropertyContainer GetFieldProperties()
        {
            if (fieldProperties != null)
            {
                return fieldProperties;
            }

            fieldProperties = new PropertyContainer("Black.Entity.Data.Wind.BonamikWindPresetEntity", base.GetFieldProperties(), -1668337179, -1898511682);
            
			
			
			return fieldProperties;
        }

		
    }
}
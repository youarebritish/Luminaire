using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Data.CharacterEntry
{
    public partial class CharaEntryPackage : Black.Entity.EntityPackage
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int loadPriority_;
		public string specialID_;
		public bool unloadWithLoadUnit_;
		public bool noAutoLoad_;
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryFixidArrayItem> noAutoLoadCharaEntryFixIDList_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new CharaEntryPackage();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Data.CharacterEntry.CharaEntryPackage", 0, Black.Entity.Data.CharacterEntry.CharaEntryPackage.ObjectType, null, properties, 0, 672);
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

            fieldProperties = new PropertyContainer("Black.Entity.Data.CharacterEntry.CharaEntryPackage", base.GetFieldProperties(), 746367485, -1612267195);
            
			
			
			return fieldProperties;
        }

		
    }
}
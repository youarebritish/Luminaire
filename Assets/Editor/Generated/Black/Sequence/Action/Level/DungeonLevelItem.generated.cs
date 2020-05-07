using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Level
{
    public partial class DungeonLevelItem : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int level_;
		public UnityEngine.Vector4 offset_;
		public string filePath_;
		public bool isCamp_;
		public UnityEngine.Vector4 campOffset_;
		public uint stayPlaceID_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new DungeonLevelItem();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Level.DungeonLevelItem", 0, Black.Sequence.Action.Level.DungeonLevelItem.ObjectType, null, properties, 0, 96);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Level.DungeonLevelItem", base.GetFieldProperties(), 1497696508, -1699292372);
            return fieldProperties;
        }

		
    }
}
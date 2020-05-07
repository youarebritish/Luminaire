using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Debug
{
    public partial class DebugCampMenuItem : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string filePath_;
		public IList<Black.Sequence.Action.Debug.DebugCampMenuCameraItem> campCameraItemList0_;
		public IList<Black.Sequence.Action.Debug.DebugCampMenuCameraItem> campCameraItemList1_;
		public IList<Black.Sequence.Action.Debug.DebugCampMenuCameraItem> campCameraItemList2_;
		public string commentJP_;
		public string commentEng_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new DebugCampMenuItem();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Debug.DebugCampMenuItem", 0, Black.Sequence.Action.Debug.DebugCampMenuItem.ObjectType, null, properties, 0, 104);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Debug.DebugCampMenuItem", base.GetFieldProperties(), 1178279095, 858728601);
            
			
			
			return fieldProperties;
        }

		
    }
}
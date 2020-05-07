using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Debug
{
    public partial class DebugCampScriptItem : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint sceneId_;
		public int cameraScene0Num_;
		public int cameraScene1Num_;
		public string commentJP_;
		public string commentEng_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new DebugCampScriptItem();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Debug.DebugCampScriptItem", 0, Black.Sequence.Action.Debug.DebugCampScriptItem.ObjectType, null, properties, 0, 56);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Debug.DebugCampScriptItem", base.GetFieldProperties(), 593959274, -1807307266);
            return fieldProperties;
        }

		
    }
}
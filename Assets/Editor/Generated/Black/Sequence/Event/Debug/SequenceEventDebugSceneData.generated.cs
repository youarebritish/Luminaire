using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Event.Debug
{
    public partial class SequenceEventDebugSceneData : SQEX.Ebony.Framework.Sequence.SequenceEvent
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string titleName_;
		public string filePath_;
		public UnityEngine.Color stringColor_;
		public bool Jump_;
		public bool Line_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin out_;
		public string labelName_;
		public uint labelFixId_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceEventDebugSceneData();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Event.Debug.SequenceEventDebugSceneData", 0, Black.Sequence.Event.Debug.SequenceEventDebugSceneData.ObjectType, null, properties, 0, 432);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Event.Debug.SequenceEventDebugSceneData", base.GetFieldProperties(), -1253432496, 559170495);
            
			
			
			return fieldProperties;
        }

		
    }
}
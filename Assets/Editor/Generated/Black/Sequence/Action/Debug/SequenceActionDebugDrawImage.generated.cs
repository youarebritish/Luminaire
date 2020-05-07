using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Debug
{
    public partial class SequenceActionDebugDrawImage : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin start_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin stop_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public string filePath_;
		public float posX_;
		public float posY_;
		public float scale_;
		public float fadeInTime_;
		public float fadeOutTime_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin posXPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin posYPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin scalePin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionDebugDrawImage();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Debug.SequenceActionDebugDrawImage", 0, Black.Sequence.Action.Debug.SequenceActionDebugDrawImage.ObjectType, null, properties, 0, 792);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Debug.SequenceActionDebugDrawImage", base.GetFieldProperties(), 439770567, 649632109);
            
			
			
			return fieldProperties;
        }

		
    }
}
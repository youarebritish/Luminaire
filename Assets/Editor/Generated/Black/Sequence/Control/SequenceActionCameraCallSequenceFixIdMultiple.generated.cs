using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Control
{
    public partial class SequenceActionCameraCallSequenceFixIdMultiple : SQEX.Ebony.Framework.Sequence.Control.SequenceControl
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin start1Pin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin stopPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin lastSceneKeepPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin taskIdPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin taskSetPin_;
		public bool lastSceneKeep_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionCameraCallSequenceFixIdMultiple();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Control.SequenceActionCameraCallSequenceFixIdMultiple", 0, Black.Sequence.Control.SequenceActionCameraCallSequenceFixIdMultiple.ObjectType, null, properties, 0, 768);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Control.SequenceActionCameraCallSequenceFixIdMultiple", base.GetFieldProperties(), -805886038, 830375286);
            return fieldProperties;
        }

		
    }
}
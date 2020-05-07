using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Render
{
    public partial class SequenceActionVisualizerControl : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public bool fpsEnabled_;
		public bool graphicsConfigEnabled_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin fpsEnabled_in;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin graphicsConfigEnabled_in;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin fpsEnabled_out;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin graphicsConfigEnabled_out;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionVisualizerControl();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Render.SequenceActionVisualizerControl", 0, Black.Sequence.Action.Render.SequenceActionVisualizerControl.ObjectType, null, properties, 0, 728);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Render.SequenceActionVisualizerControl", base.GetFieldProperties(), -1599364316, -408569985);
            
			
			
			return fieldProperties;
        }

		
    }
}
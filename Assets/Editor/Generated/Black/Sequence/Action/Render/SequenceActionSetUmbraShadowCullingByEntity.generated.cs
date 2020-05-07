using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Render
{
    public partial class SequenceActionSetUmbraShadowCullingByEntity : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin enabled_pin_;
		public bool isEnabled_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin entity_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetUmbraShadowCullingByEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Render.SequenceActionSetUmbraShadowCullingByEntity", 0, Black.Sequence.Action.Render.SequenceActionSetUmbraShadowCullingByEntity.ObjectType, null, properties, 0, 456);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Render.SequenceActionSetUmbraShadowCullingByEntity", base.GetFieldProperties(), -1441429505, -780321020);
            return fieldProperties;
        }

		
    }
}
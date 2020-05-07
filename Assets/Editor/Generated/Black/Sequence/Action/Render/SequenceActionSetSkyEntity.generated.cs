using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Render
{
    public partial class SequenceActionSetSkyEntity : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public Black.Entity.Render.SkyTextureEntity entityPointer_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin skyEntity_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public float weight_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin weightPin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetSkyEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Render.SequenceActionSetSkyEntity", 0, Black.Sequence.Action.Render.SequenceActionSetSkyEntity.ObjectType, null, properties, 0, 560);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Render.SequenceActionSetSkyEntity", base.GetFieldProperties(), 720649112, 590984997);
            return fieldProperties;
        }

		
    }
}
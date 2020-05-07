using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Vfx
{
    public partial class SequenceActionLmVFXPlay : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin play_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin normalStop_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin stop_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin fadeStop_;
		public string updateList_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin vfxEntityPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin attachActorPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin transPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin rotPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin scalePin_;
		public bool isUpdatedWhilePausing_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionLmVFXPlay();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Vfx.SequenceActionLmVFXPlay", 0, Black.Sequence.Action.Vfx.SequenceActionLmVFXPlay.ObjectType, null, properties, 0, 1208);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Vfx.SequenceActionLmVFXPlay", base.GetFieldProperties(), 2083606642, -1892305973);
            
			
			
			return fieldProperties;
        }

		
    }
}
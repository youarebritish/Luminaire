using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence
{
    public partial class SequenceActionSetPlayerInvincible : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin actors_;
		public bool invincible_;
		public bool damage9999_;
		public int saveDataState_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetPlayerInvincible();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.SequenceActionSetPlayerInvincible", 0, Black.Sequence.SequenceActionSetPlayerInvincible.ObjectType, null, properties, 0, 464);
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

            fieldProperties = new PropertyContainer("Black.Sequence.SequenceActionSetPlayerInvincible", base.GetFieldProperties(), 1870122419, -1747032344);
            return fieldProperties;
        }

		
    }
}
using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Level.Battle
{
    public partial class SequenceActionCheckGameOver : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin stop_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin play_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin over_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin alive_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin death_;
		public bool updateStatusFlag_;
		public bool changeActivate_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionCheckGameOver();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Level.Battle.SequenceActionCheckGameOver", 0, Black.Sequence.Action.Level.Battle.SequenceActionCheckGameOver.ObjectType, null, properties, 0, 856);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Level.Battle.SequenceActionCheckGameOver", base.GetFieldProperties(), 1955728257, 1445827375);
            
			
			
			return fieldProperties;
        }

		
    }
}
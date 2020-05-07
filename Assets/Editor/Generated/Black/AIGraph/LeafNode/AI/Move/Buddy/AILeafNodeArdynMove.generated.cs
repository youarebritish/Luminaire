using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Move.Buddy
{
    public partial class AILeafNodeArdynMove : Black.AIGraph.LeafNode.AI.Action.AILeafNodeSendMessageBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum moveMode_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat timeout_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat arrivalDistance_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat speed_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyVector targetPosition_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum targetSlotType_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool bEosUseActorStatusSpeed_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat minMoveAroundRadius_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat maxMoveAroundRadius_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat minMoveAroundAngle_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat maxMoveAroundAngle_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool bEosMoveY_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum eosMoveAroundSphereArea_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat acceleration_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat maxSpeed_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat minSpeed_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyVector rotation_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat distance_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum state_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool bUseTargetPosition_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool bUseTarget_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat stuckDistance_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AILeafNodeArdynMove();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Move.Buddy.AILeafNodeArdynMove", 0, Black.AIGraph.LeafNode.AI.Move.Buddy.AILeafNodeArdynMove.ObjectType, null, properties, 0, 1008);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Move.Buddy.AILeafNodeArdynMove", base.GetFieldProperties(), -1709779121, -47535153);
            return fieldProperties;
        }

		
    }
}
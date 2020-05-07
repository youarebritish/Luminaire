using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.LeafNode.AI.Move
{
    public partial class AILeafNodeRotateToTarget : SQEX.Ebony.AIGraph.Node.Leaf.AIGraphNodeLeafBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum targetType;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum targetSlotType;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid turnAnimMsg;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat targetAngle;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat offsetAngle;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat offsetAmplitude;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyEnum offsetDirType;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool waitAnimationFinish;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyInt animationReplayCount;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat timeOut;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid animBBParamId;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyInt actionType;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool forceRotation;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AILeafNodeRotateToTarget();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.LeafNode.AI.Move.AILeafNodeRotateToTarget", 0, Black.AIGraph.LeafNode.AI.Move.AILeafNodeRotateToTarget.ObjectType, null, properties, 0, 528);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.LeafNode.AI.Move.AILeafNodeRotateToTarget", base.GetFieldProperties(), 896777924, 1084456385);
            return fieldProperties;
        }

		
    }
}
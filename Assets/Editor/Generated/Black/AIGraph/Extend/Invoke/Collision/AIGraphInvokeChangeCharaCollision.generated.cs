using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.Extend.Invoke.Collision
{
    public partial class AIGraphInvokeChangeCharaCollision : SQEX.Ebony.AIGraph.Invoke.AIGraphInvokeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool isChangeCharaCollision_;
		public uint charaCollisionID_;
		public bool isChangeBGCollision_;
		public uint bgCollisionID_;
		public bool isChangeVsLimsCollision_;
		public uint vslimsCollisionID_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphInvokeChangeCharaCollision();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.Extend.Invoke.Collision.AIGraphInvokeChangeCharaCollision", 0, Black.AIGraph.Extend.Invoke.Collision.AIGraphInvokeChangeCharaCollision.ObjectType, null, properties, 0, 48);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.Extend.Invoke.Collision.AIGraphInvokeChangeCharaCollision", base.GetFieldProperties(), 364587207, -2097095197);
            return fieldProperties;
        }

		
    }
}
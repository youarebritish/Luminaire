using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Node
{
    public partial class TriggerEntityBase : Black.Entity.Node.PointNodeEntityBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint eventId_;
		public string eventString_;
		public int triggerType_;
		public int touchTarget_;
		public int characterSelectID_;
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryFixidArrayItem> CharaParamIDList;
		public int touchStatus_;
		public int touchStatus2_;
		public int touchStatus3_;
		public int touchStatus4_;
		public UnityEngine.Vector4 scaling_;
		public float radius_;
		public float height_;
		public float depth_;
		public float width_;
		public int count_;
		public bool enableTrigger_;
		public UnityEngine.Color color_;
		public bool checkInSameScene_;
		public bool scaleTriggerWithParent_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new TriggerEntityBase();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Node.TriggerEntityBase", 0, Black.Entity.Node.TriggerEntityBase.ObjectType, null, properties, 0, 448);
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

            fieldProperties = new PropertyContainer("Black.Entity.Node.TriggerEntityBase", base.GetFieldProperties(), 1250432021, -1289929382);
            return fieldProperties;
        }

		
    }
}
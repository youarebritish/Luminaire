using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Debug
{
    public partial class SequenceActionDebugMoveDump : Black.Sequence.Actor.SequenceActionActorStatusBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool dumpPosition_;
		public bool dumpRotation_;
		public bool dumpProxy_;
		public bool dumpProxyGeometry_;
		public bool dumpStat_;
		public bool dumpCallStack_;
		public bool dumpKeep_;
		public bool dumpInMainScene_;
		public int dumpKeepMaxCount_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionDebugMoveDump();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Debug.SequenceActionDebugMoveDump", 0, Black.Sequence.Action.Debug.SequenceActionDebugMoveDump.ObjectType, null, properties, 0, 496);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Debug.SequenceActionDebugMoveDump", base.GetFieldProperties(), 782212859, -2092276213);
            
			
			
			return fieldProperties;
        }

		
    }
}
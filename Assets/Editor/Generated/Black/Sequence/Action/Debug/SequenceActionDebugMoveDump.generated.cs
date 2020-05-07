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
            
			fieldProperties.AddProperty(new Property("dumpPosition_", 689557745, "bool", 480, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("dumpRotation_", 3253734786, "bool", 481, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("dumpProxy_", 3857520042, "bool", 482, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("dumpProxyGeometry_", 77624470, "bool", 483, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("dumpStat_", 2630684454, "bool", 484, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("dumpCallStack_", 489665346, "bool", 485, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("dumpKeep_", 4013194123, "bool", 486, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("dumpInMainScene_", 2547477864, "bool", 487, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("dumpKeepMaxCount_", 261107912, "int", 488, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}
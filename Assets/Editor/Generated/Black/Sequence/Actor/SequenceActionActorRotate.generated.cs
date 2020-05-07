using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor
{
    public partial class SequenceActionActorRotate : Black.Sequence.Actor.SequenceActionActorStatusBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin stop_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin forceStop_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin minSpeed_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin maxSpeed_;
		public UnityEngine.Vector4 maxSpeedVal_;
		public UnityEngine.Vector4 minSpeedVal_;
		public float accelTime_;
		public float accelTimeRandRate_;
		public float constantMaxTime_;
		public float constantMaxTimeRandRate_;
		public float decelTime_;
		public float decelTimeRandRate_;
		public float constantMinTime_;
		public float constantMinTimeRandRate_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorRotate();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.SequenceActionActorRotate", 0, Black.Sequence.Actor.SequenceActionActorRotate.ObjectType, null, properties, 0, 976);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.SequenceActionActorRotate", base.GetFieldProperties(), 1491383605, -1547809163);
            
			fieldProperties.AddProperty(new Property("stop_", 3454812878, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 480, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("forceStop_", 3742558505, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 576, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("minSpeed_", 3377264999, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 672, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("maxSpeed_", 3235919937, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 760, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("maxSpeedVal_", 2516746988, "Luminous.Math.VectorA", 848, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("minSpeedVal_", 784634890, "Luminous.Math.VectorA", 864, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("accelTime_", 665211311, "float", 880, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("accelTimeRandRate_", 1789251812, "float", 884, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("constantMaxTime_", 3598693949, "float", 888, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("constantMaxTimeRandRate_", 2377780542, "float", 892, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("decelTime_", 2202003548, "float", 896, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("decelTimeRandRate_", 2294275091, "float", 900, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("constantMinTime_", 3578840059, "float", 904, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("constantMinTimeRandRate_", 3985951232, "float", 908, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}
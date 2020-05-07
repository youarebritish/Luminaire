using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Luminous.InputDevice
{
    public partial class GyroData
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool Valid;
		public bool PadGyro;
		public UnityEngine.Vector4 Position;
		public UnityEngine.Vector4 Velocity;
		public UnityEngine.Vector4 Acceleration;
		public UnityEngine.Vector4 Orientation;
		public UnityEngine.Vector4 AngularVelocity;
		public UnityEngine.Vector4 AngularAcceleration;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new GyroData();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Luminous.InputDevice.GyroData", 0, SQEX.Luminous.InputDevice.GyroData.ObjectType, null, properties, 0, 112);
        }
		
        public  ObjectType GetObjectType()
        {
            return ObjectType;
        }

        protected  PropertyContainer GetFieldProperties()
        {
            if (fieldProperties != null)
            {
                return fieldProperties;
            }

            fieldProperties = new PropertyContainer("SQEX.Luminous.InputDevice.GyroData", null, -169428647, -1346235963);
            return fieldProperties;
        }

		
    }
}
using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Level
{
    public partial class RangedWindBase : Black.Entity.TransformEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool m_Enabled;
		public bool m_MayaLightDirection;
		public int m_VolumeType;
		public float m_Flap;
		public float m_TotalTime;
		public float m_Power;
		public float m_Offset;
		public float m_WaveLength;
		public float m_RandomPower;
		public float m_RandomOffset;
		public float m_XAxisWaveDifference;
		public float m_YAxisWaveDifference;
		public float m_RandomTime;
		public float m_RandomCycleTime;
		public float m_GravityCoefficient;
		public UnityEngine.Vector4 m_Power3;
		public UnityEngine.Vector4 m_Offset3;
		public UnityEngine.Vector4 m_WaveLength3;
		public UnityEngine.Vector4 m_PhaseDifference3;
		public UnityEngine.Vector4 m_RandomPower3;
		public UnityEngine.Vector4 m_RandomOffset3;
		public UnityEngine.Vector4 m_FrequencyMultiply3;
		public int m_WindSockDistance;
		public int m_WindSockRange;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new RangedWindBase();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Level.RangedWindBase", 0, Black.Entity.Level.RangedWindBase.ObjectType, null, properties, 0, 448);
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

            fieldProperties = new PropertyContainer("Black.Entity.Level.RangedWindBase", base.GetFieldProperties(), -1439393236, -646339722);
            
			
			
			return fieldProperties;
        }

		
    }
}
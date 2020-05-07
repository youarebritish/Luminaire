using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor
{
    public partial class SequenceActionPlayVoice : Black.Sequence.Actor.SequenceActionActorStatusBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int soundID_;
		public uint soundFixID_;
		public uint voiceLabel_;
		public bool messageFlag_;
		public int soundLevel_;
		public bool sound3Dflag_;
		public bool soundBindflag_;
		public float soundVolume_;
		public string sourcePath_;
		public bool async_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionPlayVoice();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.SequenceActionPlayVoice", 0, Black.Sequence.Actor.SequenceActionPlayVoice.ObjectType, null, properties, 0, 536);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.SequenceActionPlayVoice", base.GetFieldProperties(), -714503210, -2061078527);
            
			
			
			return fieldProperties;
        }

		
    }
}
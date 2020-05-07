using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Sound
{
    public partial class SequenceActionSetAutoTrigger : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin on_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin off_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public Black.Entity.Sound.StaticSoundEntityAuto entityPointer_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetAutoTrigger();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Sound.SequenceActionSetAutoTrigger", 0, Black.Sequence.Action.Sound.SequenceActionSetAutoTrigger.ObjectType, null, properties, 0, 472);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Sound.SequenceActionSetAutoTrigger", base.GetFieldProperties(), -971865810, 1187880558);
            return fieldProperties;
        }

		
    }
}
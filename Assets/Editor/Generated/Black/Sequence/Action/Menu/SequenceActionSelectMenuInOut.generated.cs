using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Menu
{
    public partial class SequenceActionSelectMenuInOut : Black.Sequence.Actor.SequenceActionActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin one_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin two_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin three_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin four_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin five_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin six_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin open_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin close_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin cancelled_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin reqNext_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin reqPreview_;
		public string answerString1_;
		public string answerString2_;
		public string answerString3_;
		public string answerString4_;
		public string answerString5_;
		public string answerString6_;
		public string answerStringRoman1_;
		public string answerStringRoman2_;
		public string answerStringRoman3_;
		public string answerStringRoman4_;
		public string answerStringRoman5_;
		public string answerStringRoman6_;
		public bool isPlayerControlOff_;
		public bool bSetPause_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSelectMenuInOut();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Menu.SequenceActionSelectMenuInOut", 0, Black.Sequence.Action.Menu.SequenceActionSelectMenuInOut.ObjectType, null, properties, 0, 1456);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Menu.SequenceActionSelectMenuInOut", base.GetFieldProperties(), 684135590, 1658593015);
            return fieldProperties;
        }

		
    }
}
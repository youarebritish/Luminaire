using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Level
{
    public partial class SequenceActionSetMemoryQuest : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin gotoLusis_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin gotoAlteshie_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin gotoCurrent_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin landingOnLusis_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin landingOnAlteshie_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin passedChapter_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin firstMemoryQuest_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin notFirstMemoryQuest_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin nowPresent_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin passed_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin nowAltesieOut_;
		public uint questId_;
		public uint questProgressId_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetMemoryQuest();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Level.SequenceActionSetMemoryQuest", 0, Black.Sequence.Action.Level.SequenceActionSetMemoryQuest.ObjectType, null, properties, 0, 1472);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Level.SequenceActionSetMemoryQuest", base.GetFieldProperties(), 900820320, 1545541376);
            
			
			
			return fieldProperties;
        }

		
    }
}
using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Menu
{
    public partial class SequenceActionCommonDialog : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin openIPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin closeIPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin requestLoadIPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin unloadIPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin imageIdIPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin captionTextIdPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outOPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin openedOPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin closedOPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin selectedYesOPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin selectedNoOPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin selected1OPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin selected2OPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin selected3OPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin selected4OPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin selected5OPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin canceledOPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin loadFinishedOPin_;
		public float disableCloseSeconds_;
		public bool enablePause_;
		public bool disableCancelButton_;
		public int dialogType_;
		public uint captionTextId_;
		public bool defaultSelectNo_;
		public uint select01TextId_;
		public uint select02TextId_;
		public uint select03TextId_;
		public uint select04TextId_;
		public uint select05TextId_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin select01TextPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin select02TextPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin select03TextPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin select04TextPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin select05TextPin_;
		public int initialIndex_;
		public bool isAutoUnloadRequest_;
		public bool closeOnlyIfOpener_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionCommonDialog();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Menu.SequenceActionCommonDialog", 0, Black.Sequence.Action.Menu.SequenceActionCommonDialog.ObjectType, null, properties, 0, 2376);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Menu.SequenceActionCommonDialog", base.GetFieldProperties(), -1335665172, 1954699063);
            
			
			
			return fieldProperties;
        }

		
    }
}
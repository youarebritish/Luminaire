using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Level
{
    public partial class SequenceActionSetSameLevelPackageLoadManager : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin up_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin down_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin finish_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin finishUpper_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin finishLower_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin completed_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin completedUpper_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin completedLower_;
		public string packagePath_;
		public string campPackagePath_;
		public IList<Black.Sequence.Action.Level.DungeonLevelItem> itemList_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin valueInitLevel_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin valueOffset_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin valueLevelOut_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin valueCampOut_;
		public UnityEngine.Vector4 offset_;
		public bool isFinish_;
		public int levelMax_;
		public bool isInformNavimeshOffset_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetSameLevelPackageLoadManager();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Level.SequenceActionSetSameLevelPackageLoadManager", 0, Black.Sequence.Action.Level.SequenceActionSetSameLevelPackageLoadManager.ObjectType, null, properties, 0, 1888);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Level.SequenceActionSetSameLevelPackageLoadManager", base.GetFieldProperties(), -1138692803, 2084106125);
            
			
			
			return fieldProperties;
        }

		
    }
}
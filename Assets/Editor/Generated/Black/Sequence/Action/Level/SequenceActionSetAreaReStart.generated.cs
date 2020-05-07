using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Level
{
    public partial class SequenceActionSetAreaReStart : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public string restartPackage_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin packagePathPin_;
		public UnityEngine.Vector4 restartPosition_;
		public uint restartFixId_;
		public IList<Black.Entity.Data.Area.SetAreaReStartItem> packageList_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin valueRestartPosition_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin valueRestartRotation_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin valueRestartPoint_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin valueRestartLabelId_;
		public bool isUseCampPoint_;
		public bool isUseReturnInfo_;
		public bool isClearWorldPackage_;
		public bool isClearUniversalPackage_;
		public uint debugSceneLabelFixId_;
		public bool isAutoRestartPackage_;
		public bool isSetNewGame_;
		public bool isSetNewGamePlus_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin valueRestartTiming_;
		public bool isMobhuntFirstTravel_;
		public bool isReturnDungeonEntrance_;
		public bool isReturnFromTutorialToWorld_;
		public uint tutorialFixId0_;
		public uint tutorialFixId1_;
		public uint tutorialFixId2_;
		public bool isOverwritePlaytimeAtReturning_;
		public bool isOverwriteSnapshotAtReturning_;
		public bool isOverwriteEnemyKillNumAtReturning_;
		public bool isSetLoadGameCarnival_;
		public bool isMaskingDLCItemDisp_;
		public float loadDistanceLimit_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetAreaReStart();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Level.SequenceActionSetAreaReStart", 0, Black.Sequence.Action.Level.SequenceActionSetAreaReStart.ObjectType, null, properties, 0, 1120);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Level.SequenceActionSetAreaReStart", base.GetFieldProperties(), 208401350, 523456246);
            
			
			
			return fieldProperties;
        }

		
    }
}
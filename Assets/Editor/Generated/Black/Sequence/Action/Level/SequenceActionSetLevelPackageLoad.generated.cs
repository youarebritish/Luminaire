using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Level
{
    public partial class SequenceActionSetLevelPackageLoad : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin isRelease_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin finish_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin completed_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin packagePathPin_;
		public string packagePath_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin valueUniqueId_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin valueLoadPosition_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin positionTargetActor_;
		public bool isRelese_;
		public bool isLoadSubPackage_;
		public bool forAreaLoading_;
		public bool isToLocateSequencePackagePosition_;
		public bool checkReleasedAtInitialLoadMode_;
		public bool isUnloadIfParentNotFound_;
		public bool isEnableSamePackageLoading_;
		public int uniqueId_;
		public UnityEngine.Vector4 loadPosition_;
		public int priorityType_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetLevelPackageLoad();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Level.SequenceActionSetLevelPackageLoad", 0, Black.Sequence.Action.Level.SequenceActionSetLevelPackageLoad.ObjectType, null, properties, 0, 1152);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Level.SequenceActionSetLevelPackageLoad", base.GetFieldProperties(), 1591238457, 27143554);
            return fieldProperties;
        }

		
    }
}
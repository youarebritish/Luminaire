using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Menu
{
    public partial class SequenceActionSelectRolesControl : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin open_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin close_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin changeLeft_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin changeRight;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin up_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin down_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin right_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin left_;
		public bool useDefaultInput_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin rolePin01_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin rolePin02_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin rolePin03_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin rolePin04_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin rolePin05_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin rolePin06_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin rolePin07_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin charaNamePinNoct_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin charaNamePinGladio_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin charaNamePinIgnis_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin charaNamePinPrompt_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin charaNamePinGuest_;
		public uint swfPartsNormalLabelFixID_;
		public uint swfPartsForcusLabelFixID_;
		public uint swfPartsFocusLeftLabelFixID_;
		public uint swfPartsFocusRightFixID_;
		public uint swfRoleNameFieldFixID_;
		public uint swfRoleLevelFieldFixID_;
		public uint swfCharaNameFieldFixID_;
		public UnityEngine.Vector4 rolesSelectOffset_;
		public UnityEngine.Vector4 rolesCharaOffset_;
		public UnityEngine.Vector4 lineOffset_;
		public uint swfSelectInLabelFixID_;
		public uint swfSelectLoopLabelFixID_;
		public uint swfSelectOutLabelFixID_;
		public uint swfSelectMoveLeftFixID_;
		public uint swfSelectMoveRightFixID_;
		public uint swfMcRolesSelectFixID_;
		public uint swfCharaInLabelFixID_;
		public uint swfCharaLoopLabelFixID_;
		public uint swfCharaOutLabelFixID_;
		public uint swfLineInLabelFixID_;
		public uint swfLineLoopLabelFixID_;
		public uint swfLineOutLabelFixID_;
		public uint swfLineMoveTopFixID_;
		public uint swfLineMoveBottomFixID_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin connectedSwfPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin linePin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin roloesSelectListPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin changed_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin L1pushed_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin R1pushed_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin Decide_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin closed_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin outSelectValue_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSelectRolesControl();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Menu.SequenceActionSelectRolesControl", 0, Black.Sequence.Action.Menu.SequenceActionSelectRolesControl.ObjectType, null, properties, 0, 3104);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Menu.SequenceActionSelectRolesControl", base.GetFieldProperties(), 1653901104, 367657963);
            return fieldProperties;
        }

		
    }
}
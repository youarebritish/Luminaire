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
            
			fieldProperties.AddProperty(new Property("open_", 1412397090, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 176, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("close_", 552510516, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 272, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("changeLeft_", 3228656965, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 368, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("changeRight", 733568877, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 464, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("up_", 1636505837, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 560, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("down_", 1969139582, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 656, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("right_", 127990734, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 752, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("left_", 4210150909, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 848, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("useDefaultInput_", 1534227088, "bool", 944, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("rolePin01_", 1060403100, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 952, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("rolePin02_", 1060550195, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1040, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("rolePin03_", 4281896970, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1128, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("rolePin04_", 1060844385, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1216, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("rolePin05_", 1060991480, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1304, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("rolePin06_", 4282441423, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1392, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("rolePin07_", 4282588518, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1480, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("charaNamePinNoct_", 756561671, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1568, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("charaNamePinGladio_", 2157582569, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1656, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("charaNamePinIgnis_", 3481578133, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1744, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("charaNamePinPrompt_", 3675151497, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1832, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("charaNamePinGuest_", 1210677079, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1920, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("swfPartsNormalLabelFixID_", 2331598665, "SQEX.Ebony.Std.Fixid", 2008, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("swfPartsForcusLabelFixID_", 156789812, "SQEX.Ebony.Std.Fixid", 2012, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("swfPartsFocusLeftLabelFixID_", 1745505013, "SQEX.Ebony.Std.Fixid", 2016, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("swfPartsFocusRightFixID_", 522270874, "SQEX.Ebony.Std.Fixid", 2020, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("swfRoleNameFieldFixID_", 2755226171, "SQEX.Ebony.Std.Fixid", 2024, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("swfRoleLevelFieldFixID_", 779096866, "SQEX.Ebony.Std.Fixid", 2028, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("swfCharaNameFieldFixID_", 2795397648, "SQEX.Ebony.Std.Fixid", 2032, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("rolesSelectOffset_", 3225544954, "Luminous.Math.VectorA", 2048, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("rolesCharaOffset_", 4235052619, "Luminous.Math.VectorA", 2064, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("lineOffset_", 3007963065, "Luminous.Math.VectorA", 2080, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("swfSelectInLabelFixID_", 665328489, "SQEX.Ebony.Std.Fixid", 2096, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("swfSelectLoopLabelFixID_", 3998518578, "SQEX.Ebony.Std.Fixid", 2100, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("swfSelectOutLabelFixID_", 2311975214, "SQEX.Ebony.Std.Fixid", 2104, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("swfSelectMoveLeftFixID_", 3128765128, "SQEX.Ebony.Std.Fixid", 2108, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("swfSelectMoveRightFixID_", 4054135835, "SQEX.Ebony.Std.Fixid", 2112, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("swfMcRolesSelectFixID_", 4170224055, "SQEX.Ebony.Std.Fixid", 2116, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("swfCharaInLabelFixID_", 3660646898, "SQEX.Ebony.Std.Fixid", 2120, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("swfCharaLoopLabelFixID_", 3151777653, "SQEX.Ebony.Std.Fixid", 2124, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("swfCharaOutLabelFixID_", 4282202811, "SQEX.Ebony.Std.Fixid", 2128, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("swfLineInLabelFixID_", 2034173955, "SQEX.Ebony.Std.Fixid", 2132, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("swfLineLoopLabelFixID_", 711215072, "SQEX.Ebony.Std.Fixid", 2136, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("swfLineOutLabelFixID_", 2742180116, "SQEX.Ebony.Std.Fixid", 2140, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("swfLineMoveTopFixID_", 3393681788, "SQEX.Ebony.Std.Fixid", 2144, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("swfLineMoveBottomFixID_", 3325589540, "SQEX.Ebony.Std.Fixid", 2148, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("connectedSwfPin_", 3223910404, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2152, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("linePin_", 3458259875, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2240, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("roloesSelectListPin_", 3033171663, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 2328, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("changed_", 939093132, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 2416, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("L1pushed_", 1582319208, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 2512, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("R1pushed_", 3372510962, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 2608, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("Decide_", 2465472314, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 2704, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("closed_", 36233838, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 2800, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outSelectValue_", 507372225, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 2896, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}
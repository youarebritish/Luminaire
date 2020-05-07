using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor
{
    public partial class SequenceActionActorPlayBodyLinkAnim : Black.Sequence.Actor.SequenceActionActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin playPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin stopPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin pinningPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin masterPointPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin masterTargetPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin finishedPin_;
		public string sceneAssetPath_;
		public bool bKeepInSyncVertically_;
		public float syncTime_;
		public bool syncFinish_;
		public int masterPointType_;
		public bool playAlive_;
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryFixidArrayItem> penetrateRoleList_;
		public IList<Black.Sequence.Action.Actor.SequenceActionActorPlayBodyLinkAnimTransitionTime> transitionTimeList_;
		public IList<Black.Sequence.Action.Actor.SequenceActionActorPlayBodyLinkAnimStatus> statusList_;
		public bool bNotifyBodyLayer_;
		public bool bStopAI_;
		public uint facial_1_role_;
		public string facial_1_aniPath_;
		public float facial_1_blendTime_;
		public uint facial_2_role_;
		public string facial_2_aniPath_;
		public float facial_2_blendTime_;
		public uint facial_3_role_;
		public string facial_3_aniPath_;
		public float facial_3_blendTime_;
		public uint facial_4_role_;
		public string facial_4_aniPath_;
		public float facial_4_blendTime_;
		public string lastSceneAssetPath_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorPlayBodyLinkAnim();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.SequenceActionActorPlayBodyLinkAnim", 0, Black.Sequence.Action.Actor.SequenceActionActorPlayBodyLinkAnim.ObjectType, null, properties, 0, 1408);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.SequenceActionActorPlayBodyLinkAnim", base.GetFieldProperties(), 1741251185, 2095117162);
            
			fieldProperties.AddProperty(new Property("playPin_", 1036284367, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 184, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("stopPin_", 2226130577, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 280, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("pinningPin_", 3092394450, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 376, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("masterPointPin_", 1573507831, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 464, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("masterTargetPin_", 479553702, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 552, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outPin_", 2732252299, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 640, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("finishedPin_", 1775979791, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 736, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("sceneAssetPath_", 1260398091, "SQEX.Ebony.Base.String", 832, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("bKeepInSyncVertically_", 3491763818, "bool", 848, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("syncTime_", 3367664428, "float", 852, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("syncFinish_", 1453713390, "bool", 856, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("masterPointType_", 2356250964, "Black.Sequence.Action.Actor.SequenceActionActorPlayBodyLinkAnim.MasterPoint", 860, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("playAlive_", 1454687153, "bool", 864, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("penetrateRoleList_", 898449792, "SQEX.Ebony.Std.DynamicArray< Black.Entity.Data.CharacterEntry.CharacterEntryFixidArrayItem* >", 872, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)2));
			fieldProperties.AddProperty(new Property("transitionTimeList_", 938345852, "SQEX.Ebony.Std.DynamicArray< Black.Sequence.Action.Actor.SequenceActionActorPlayBodyLinkAnimTransitionTime* >", 888, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)2));
			fieldProperties.AddProperty(new Property("statusList_", 1296808024, "SQEX.Ebony.Std.DynamicArray< Black.Sequence.Action.Actor.SequenceActionActorPlayBodyLinkAnimStatus* >", 904, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)2));
			fieldProperties.AddProperty(new Property("bNotifyBodyLayer_", 4014474134, "bool", 920, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("bStopAI_", 2964653536, "bool", 921, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("facial_1_role_", 2984832787, "SQEX.Ebony.Std.Fixid", 924, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("facial_1_aniPath_", 2455400144, "Ebony.Base.String", 928, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("facial_1_blendTime_", 958835057, "float", 944, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("facial_2_role_", 3495418278, "SQEX.Ebony.Std.Fixid", 948, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("facial_2_aniPath_", 2797102135, "Ebony.Base.String", 952, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("facial_2_blendTime_", 2334865334, "float", 968, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("facial_3_role_", 1555836357, "SQEX.Ebony.Std.Fixid", 972, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("facial_3_aniPath_", 4087762746, "Ebony.Base.String", 976, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("facial_3_blendTime_", 176769007, "float", 992, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("facial_4_role_", 774886312, "SQEX.Ebony.Std.Fixid", 996, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("facial_4_aniPath_", 4242710369, "Ebony.Base.String", 1000, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("facial_4_blendTime_", 4218484676, "float", 1016, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("lastSceneAssetPath_", 636227631, "SQEX.Ebony.Base.String", 1344, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}
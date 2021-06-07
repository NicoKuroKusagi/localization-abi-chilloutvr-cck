using System.Collections.Generic;

namespace ABI.CCK.Scripts.Translation
{
    public class Chinese
    {
        public static readonly Dictionary<string, string> Localization = new Dictionary<string, string>()
        {
            {"ABI_UI_BUILDPANEL_HEADING_BUILDER", "内容构建"},
            {"ABI_UI_BUILDPANEL_HEADING_SETTINGS", "选项设置"},
            {"ABI_UI_BUILDPANEL_HEADING_DOCUMENTATION", "查看文档"},
            {"ABI_UI_BUILDPANEL_HEADING_FEEDBACK", "提交反馈"},
            {"ABI_UI_BUILDPANEL_HEADING_FOUNDCONTENT", "活动场景中的内容"},
            {"ABI_UI_BUILDPANEL_HEADING_ACCOUNT_INFO", "账号信息"},
            {"ABI_UI_BUILDPANEL_LOGIN_CREDENTIALS_INCORRECT", "提供的登录凭据不正确。"},
            {"ABI_UI_BUILDPANEL_LOGIN_BUTTON", "登录"},
            {"ABI_UI_BUILDPANEL_LOGOUT_BUTTON", "登出"},
            {"ABI_UI_BUILDPANEL_LOGOUT_DIALOG_TITLE", "移除CCK的本地登录凭据"},
            {
                "ABI_UI_BUILDPANEL_LOGOUT_DIALOG_BODY",
                "这将移除本地保存的凭据，你将会需要重新验证，确定继续吗？"
            },
            {"ABI_UI_BUILDPANEL_LOGOUT_DIALOG_ACCEPT", "是"},
            {"ABI_UI_BUILDPANEL_LOGOUT_DIALOG_DECLINE", "否"},

            {"ABI_UI_BUILDPANEL_UPLOADER_NO_AVATARS_FOUND", "在场景中找不到已经配置的Avatar - 是否添加了CVRAvatar？"},
            {
                "ABI_UI_BUILDPANEL_UPLOADER_NO_SPAWNABLES_FOUND",
                "在场景中找不到已经配置的可生成的对象 - 是否添加了CVRSpawnable？"
            },
            {
                "ABI_UI_BUILDPANEL_WORLDS_WARNING_SPAWNPOINT",
                "你的世界没有指定任何出生点，请添加一个或者多个出生点在CVRWorld组件中，否则CVRWorld holder对象的位置将被使用。"
            },
            {
                "ABI_UI_BUILDPANEL_WORLDS_INFO_REFERENCE_CAMERA",
                "你的世界没有指定参考摄像机，默认的摄像机配置将被使用。"
            },
            {
                "ABI_UI_BUILDPANEL_WORLDS_INFO_RESPAWN_HEIGHT",
                "出生点高度低于-500，从地图上掉出要花很长时间才能重生，这可能不是你想要的。"
            },
            {
                "ABI_UI_BUILDPANEL_WORLDS_ERROR_MULTIPLE_CVR_WORLD",
                "场景中存在多个CVR世界对象。这将导致世界发生问题。请确保场景中仅有一个CVRWorld对象或使用我们的CVR世界预制体。"
            },
            {
                "ABI_UI_BUILDPANEL_WORLDS_ERROR_WORLD_CONTAINS_AVATAR",
                "被加载的场景不应该同时包含Avatar和世界描述符组件，请根据实际情况设置场景。"
            },
            {
                "ABI_UI_BUILDPANEL_WORLDS_ERROR_NO_CONTENT",
                "在当前场景中找不到任何内容，你是否忘了给游戏对象添加描述符对象？"
            },
            {
                "ABI_UI_BUILDPANEL_WORLDS_ERROR_UNITY_UNSUPPORTED",
                "你正在使用不受支持的unity版本。请使用受支持的unity版本，你可以在我们的文档中检查与你的CCK版本对应的支持版本。"
            },
            {"ABI_UI_BUILDPANEL_UPLOAD_WORLD_BUTTON", "上传世界"},
            {"ABI_UI_BUILDPANEL_UPLOAD_AVATAR_BUTTON", "上传Avatar"},
            {"ABI_UI_BUILDPANEL_UPLOAD_PROP_BUTTON", "上载可生成对象"},
            {"ABI_UI_BUILDPANEL_FIX_IMPORT_SETTINGS", "修复导入设置"},
            {"ABI_UI_BUILDPANEL_UTIL_REMOVE_MISSING_SCRIPTS_BUTTON", "删除所有丢失的脚本"},
            {"ABI_UI_BUILDPANEL_LOGIN_TEXT_USERNAME", "用户名"},
            {"ABI_UI_BUILDPANEL_LOGIN_TEXT_ACCESSKEY", "访问密钥"},
            {
                "ABI_UI_BUILDPANEL_INFOTEXT_DOCUMENTATION",
                "使用我们的文档了解有关如何创建游戏内容的更多信息，你还将找到一些关于如何使用多数的核心的引擎功能以及核心的游戏功能的方便教程。"
            },
            {"ABI_UI_BUILDPANEL_INFOTEXT_SIGNIN1", "请使用您的CCK凭据进行验证。"},
            {"ABI_UI_BUILDPANEL_INFOTEXT_SIGNIN2", "你可以在hub.abinteractive.net上找到它们。"},
            {"ABI_UI_BUILDPANEL_INFOTEXT_SIGNIN3", "请在密钥管理器中生成CCK密钥。"},
            {"ABI_UI_BUILDPANEL_INFOTEXT_AUTHENTICATED_AS", "身份验证为"},
            {"ABI_UI_BUILDPANEL_INFOTEXT_USER_RANK", "API用户等级"},
            {"ABI_UI_BUILDPANEL_SETTINGS_HEADER", "上传设置"},
            {"ABI_UI_BUILDPANEL_SETTINGS_CONTENT_ENCRYPTION", "切换网络连接加密："},
            {
                "ABI_UI_BUILDPANEL_SETTINGS_HINT_CONTENT_ENCRYPTION",
                "如果上传遇到问题，请尝试切换到http。"
            },
            {"ABI_UI_BUILDPANEL_SETTINGS_CONTENT_REGION", "上传地域："},
            {
                "ABI_UI_BUILDPANEL_SETTINGS_HINT_CONTENT_REGION",
                "你可以切换上传地域来提高上传速度。你的内容仍将在所有地域内可用。"
            },
            {"ABI_UI_BUILDPANEL_SETTINGS_CCK_LANGUAGE", "CCK语言:"},
            {
                "ABI_UI_BUILDPANEL_SETTINGS_HINT_CCK_LANGUAGE",
                "你可以在这里切换CCK语言，以便用所倾向的语言来获取通知及UI文本。"
            },
            {
                "ABI_UI_BUILDPANEL_WARNING_FOLDERPATH",
                "请不要移动CCK或CCK Mods文件夹的位置，这将导致CCK无法使用。"
            },
            {
                "ABI_UI_BUILDPANEL_WARNING_FEEDBACK",
                "想要请求新功能吗？找到了BUG？请在我们的反馈平台提交！"
            },
            {"ABI_UI_BUILDPANEL_WARNING_MESH_FILTER_MESH_EMPTY", "检测到缺少网格的网格过滤器"},
            {
                "ABI_UI_BUILDPANEL_AVATAR_ERROR_ANIMATOR",
                "在这个Avatar上没有找到Animator，确保Animator和CVRAvatar组件在同一个游戏对象上。"
            },
            {
                "ABI_UI_BUILDPANEL_AVATAR_WARNING_GENERIC",
                "你的Avatar Animator上有没被填写的Avatar空位，你的Avatar将被视为普通Avatar。"
            },
            {
                "ABI_UI_BUILDPANEL_AVATAR_WARNING_POLYGONS",
                "警告：此Avatar包含超过100k ({X}) 个多边形，这可能导致游戏中出现性能问题，但不会阻止你上传。"
            },
            {
                "ABI_UI_BUILDPANEL_AVATAR_WARNING_SKINNED_MESH_RENDERERS",
                "警告：此Avatar包含超过10 ({X}) 个带蒙皮的网格渲染器组件，这可能导致游戏中出现性能问题，但不会阻止你上传。"
            },
            {
                "ABI_UI_BUILDPANEL_AVATAR_WARNING_MATERIALS",
                "警告：此Avatar使用了超过20 ({X}) 个材质空位，这可能导致游戏中出现性能问题，但不会阻止你上传。"
            },
            {
                "ABI_UI_BUILDPANEL_AVATAR_WARNING_VIEWPOINT",
                "警告：此Avatar的视角位置默认为X=0,Y=0,Z=0。这意味着你的视角在地面上，这可能不是你想要的。"
            },
            {"ABI_UI_BUILDPANEL_AVATAR_WARNING_NON_HUMANOID", "警告：你的Avatar没有设置为人形。"},
            {
                "ABI_UI_BUILDPANEL_AVATAR_WARNING_LEGACY_BLENDSHAPES",
                "警告：此Avatar没有传统的BlendShape法线，这将导致文件变大以及照明错误。"
            },
            {
                "ABI_UI_BUILDPANEL_AVATAR_INFO_POLYGONS",
                "信息：这个Avatar包含超过50k ({X}) 个多边形，这可能导致游戏中出现性能问题，但不会阻止你上传"
            },
            {
                "ABI_UI_BUILDPANEL_AVATAR_INFO_SKINNED_MESH_RENDERERS",
                "信息：此Avatar包含超过5 ({X}) 个带蒙皮的网格渲染器组件，这可能导致游戏中出现性能问题，但不会阻止你上传。"
            },
            {
                "ABI_UI_BUILDPANEL_AVATAR_INFO_MATERIALS",
                "信息：此Avatar使用了超过 10 ({X}) 个材质空位，这可能导致游戏中出现性能问题，但不会阻止你上传。"
            },
            {
                "ABI_UI_BUILDPANEL_AVATAR_INFO_SMALL",
                "信息：此Avatar的视角高度低于0.5，这个Avatar将被认定为极小。"
            },
            {
                "ABI_UI_BUILDPANEL_AVATAR_INFO_HUGE",
                "信息：此Avatar的视角高度高于3.0，这个Avatar将被认定为极大。"
            },
            {"ABI_UI_BUILDPANEL_AVATAR_UPLOAD_BUTTON", "上传Avatar"},
            {
                "ABI_UI_BUILDPANEL_PROPS_ERROR_MISSING_SCRIPT",
                "可生成的对象或其子对象包含丢失的脚本。上传会因此失败。在上传之前删除所有丢失的脚本引用，或者单击“删除所有丢失的脚本”自动完成此操作。"
            },
            {
                "ABI_UI_BUILDPANEL_PROPS_WARNING_POLYGONS",
                "警告：这个可生成的对象包含超过100k ({X}) 个多边形，这可能导致游戏中出现性能问题，但不会阻止你上传。"
            },
            {
                "ABI_UI_BUILDPANEL_PROPS_WARNING_SKINNED_MESH_RENDERERS",
                "警告：此可生成对象包含超过 10 ({X}) 个带蒙皮的网格渲染器组件，这可能导致游戏中出现性能问题，但不会阻止你上传。"
            },
            {
                "ABI_UI_BUILDPANEL_PROPS_WARNING_MATERIALS",
                "警告：此可生成对象使用了超过 20 ({X}) 个材质空位，这可能导致游戏中出现性能问题，但不会阻止你上传。"
            },
            {
                "ABI_UI_BUILDPANEL_PROPS_WARNING_LEGACY_BLENDSHAPES",
                "警告：此可生成对象没有传统的BlendShape法线，这将导致文件变大以及照明错误。"
            },
            {
                "ABI_UI_BUILDPANEL_PROPS_INFO_POLYGONS",
                "信息：此可生成对象包含超过 50k ({X}) 个多边形， 这可能导致游戏中出现性能问题，但不会阻止你上传。"
            },
            {
                "ABI_UI_BUILDPANEL_PROPS_INFO_SKINNED_MESH_RENDERERS",
                "信息：此可生成对象包含超过 5 ({X}) 个带蒙皮的网格渲染器组件，这可能导致游戏中出现性能问题，但不会阻止你上传。"
            },
            {
                "ABI_UI_BUILDPANEL_PROPS_INFO_MATERIALS",
                "信息：此可生成对象使用了超过 10 ({X}) 个材质空位，这可能导致游戏中出现性能问题，但不会阻止你上传。"
            },
            {"ABI_UI_BUILDPANEL_PROPS_UPLOAD_BUTTON", "上传可生成的物体 (Prop)"},
            {
                "ABI_UI_BUILDPANEL_ERROR_WORLD_MISSING_SCRIPTS",
                "场景包含丢失的脚本。上传会因此失败。在上传之前删除所有丢失的脚本引用，或者单击“删除所有丢失的脚本”自动完成此操作。"
            },
            {
                "ABI_UI_BUILDPANEL_ERROR_AVATAR_MISSING_SCRIPTS",
                "Avatar或其子对象包含丢失的脚本。上传会因此失败。在上传之前删除所有丢失的脚本引用，或者单击“删除所有丢失的脚本”自动完成此操作。"
            },
            {
                "ABI_UI_ADVAVTR_TRIGGER_MULTIPLE_TRIGGER_HELPBOX",
                "在同一个游戏对象上有多个触发器会导致不可预知的行为！"
            },
            {
                "ABI_UI_ADVAVTR_TRIGGER_ALLOWED_POINTERS_HELPBOX",
                "添加Pointers到\"允许的Pointers\" 列表将忽略其中不包含的所有其他Pointers"
            },
            {
                "ABI_UI_ADVAVTR_TRIGGER_ALLOWED_TYPES_HELPBOX",
                "添加类型到\"允许的类型\" 列表将忽略其中不包含的所有其他类型"
            },
            {
                "ABI_UI_ADVAVTR_TRIGGER_PARTICLE_HELPBOX",
                "启用此选项将允许在同一游戏对象上有pointer的粒子系统激活此触发器。粒子只能在输入触发器时触发。"
            },
            {
                "ABI_UI_INFOTEXT_WORLDS_NO_AVATARS",
                "在场景中发现一个ChilloutVR世界对象，在世界对象被移除之前，无法上传Avatars，Avatars / 可生成对象将是世界的一部分，并且在世界上可见，除非它们被禁用或移除。"
            },
            {
                "ABI_UI_ASSET_INFO_HEADER_INFORMATION",
                "此脚本用于存储对象元信息。请不要修改上面的数据，除非你知道你在做什么，要重新上传一个Avatar，请解绑Guid并重新上传。"
            },
            {"ABI_UI_ASSET_INFO_GUID_LABEL", "当前存储的Guid为: "},
            {"ABI_UI_ASSET_INFO_DETACH_BUTTON", "解绑asset唯一标识符"},
            {"ABI_UI_ASSET_INFO_DETACH_BUTTON_DIALOG_TITLE", "从Asset信息管理器中解绑Guid"},
            {
                "ABI_UI_ASSET_INFO_DETACH_BUTTON_DIALOG_BODY",
                "将解绑Asset唯一标识符，这意味着你内容很可能被运行时作为新内容上传，继续吗？"
            },
            {"ABI_UI_ASSET_INFO_DETACH_BUTTON_DIALOG_ACCEPT", "是"},
            {"ABI_UI_ASSET_INFO_DETACH_BUTTON_DIALOG_DENY", "否"},
            {"ABI_UI_ASSET_INFO_ATTACH_LABEL", "唯一标识符"},
            {
                "ABI_UI_ASSET_INFO_ATTACH_INFO",
                "如果你没有打算覆盖旧的上传内容，则不需要重新绑定Guid，当前没有绑定则会在上传时将生成一个。"
            },
            {"ABI_UI_ASSET_INFO_ATTACH_BUTTON", "重新绑定guid"},
            {
                "ABI_UI_AVATAR_INFO_VIEWPOINT",
                "控制玩家在游戏中视角相机绑定的位置，这个应该在你的两只眼睛之间。"
            },
            {
                "ABI_UI_AVATAR_INFO_VOICE_POSITION",
                "控制玩家在游戏中的声音绑定的位置。这个应该在你的嘴上。"
            },
            {
                "ABI_UI_AVATAR_INFO_OVERRIDE_CONTROLLER",
                "要使覆盖生效，请确保在覆盖控制器中指定了正确的animator，否则，将看不到要覆盖的animator空位，一个例子在CCK Player Prefabs文件夹中。"
            },
            {
                "ABI_UI_AVATAR_INFO_BLinking",
                "眨眼的形态键的使用是可选的，它可以在运行时生成随机眨眼。"
            },
            {
                "ABI_UI_AVATAR_INFO_EYE_MOVEMENT",
                "选中此选项将开启眼睛的半真实的动画。"
            },
            {
                "ABI_UI_AVATAR_INFO_EYE_VISEMES",
                "要使“自动选择发音嘴型”功能正常工作，必须首先选择包含face的网格。在大多数情况下，这将是body网格。"
            },
            {
                "ABI_UI_MODULE_WORKSHOP_MISSING_DEPENDENCIES_TITLE",
                "项目中缺少依赖项！"
            },
            {
                "ABI_UI_MODULE_WORKSHOP_MISSING_DEPENDENCIES_WARNING_PREFACE",
                "以下依赖项未满足"
            },
            {
                "ABI_UI_MODULE_WORKSHOP_MISSING_DEPENDENCIES_FINAL_WARNING",
                "请在安装此模块之前安装所有依赖项！"
            },
            {
                "ABI_UI_MODULE_WORKSHOP_MISSING_DEPENDENCIES_DIALOG_ACCEPT",
                "了解"
            }
        };
    }
}
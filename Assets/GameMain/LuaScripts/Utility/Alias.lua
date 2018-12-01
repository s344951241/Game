--
-- 别名
-- 描述：把常用的组件保存在这里
-- ======================================

-- NameSpace Alias
-- ======================================
UE              = CS.UnityEngine
GF              = CS.GameFramework
UGF             = CS.UnityGameFramework.Runtime
Game            = CS.Game

-- .NET Alias
-- ======================================
String          = CS.System.String
DateTime        = CS.System.DateTime

-- Unity Alias
-- ======================================
Time            = UE.Time
Vector2         = UE.Vector2
Vector3         = UE.Vector3
Color           = UE.Color
GameObject      = UE.GameObject
Matrix4x4       = UE.Matrix4x4
Quaternion      = UE.Quaternion
Math            = UE.Mathf
Rect            = UE.Rect
WWW             = UE.WWW
WWWForm         = UE.WWWForm
Camera          = UE.Camera
Input           = UE.Input
KeyCode         = UE.KeyCode
IsEditor        = UE.Application.isEditor and true or false
SceneManager    = UE.SceneManagement.SceneManager

-- Common Alias
-- ======================================
Log             = UGF.Log
PLog            = Game.PLog
ReferencePool   = GF.ReferencePool
Utility         = GF.Utility
GameEntry       = Game.GameEntry
LuaHelper       = Game.LuaHelper
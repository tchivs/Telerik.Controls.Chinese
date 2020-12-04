using System;
using System.Collections.Generic;
using Telerik.Windows.Controls;

namespace Telerik.Controls.Chinese
{
    public class ChineseLocalizationManager : LocalizationManager
    {
        /// <summary>
        /// 在匹配失败时发生,可以在这里面继续匹配key
        /// </summary>
        public Func<KeyValuePair<string, string>, string> OnKeyNotFound { get; set; }

        private string GetStringWithLog(string key)
        {
            var res = base.GetStringOverride(key);
            var pattern = OnKeyNotFound?.Invoke(new KeyValuePair<string, string>(key, res));
            if (!string.IsNullOrEmpty(pattern))
            {
                res = pattern;
            }

            return res;
        }

        public override string GetStringOverride(string key)
        {
            return key switch

            {
                "DataForm_MoveCurrentToFirst" => "第一项",
                "DataForm_AddNew" => "添加",
                "DataForm_Delete" => "删除",
                "DataForm_BeginEdit" => "编辑",
                "DataForm_MoveCurrentToLast" => "最后一项",
                "DataForm_MoveCurrentToPrevious" => "上一项",
                "DataForm_MoveCurrentToNext" => "下一项",
                "FileDialogs_Back" => "返回",
                "FileDialogs_Cancel" => "取消",
                "FileDialogs_CheckThePath" => "检查路径，然后重试。",
                "FileDialogs_ConfirmSave" => "确认另存为",
                "FileDialogs_Copy" => "复制",
                "FileDialogs_CopyTo" => "复制到",
                "FileDialogs_Cut" => "剪切",
                "FileDialogs_DateHeader" => "修改日期",
                "FileDialogs_Delete" => "删除",
                "FileDialogs_Details" => "详情",
                "FileDialogs_Edit" => "编辑",
                "FileDialogs_ExtraLargeIcons" => "特大图标",
                "FileDialogs_FileExists" => "已经存在",
                "FileDialogs_FileFolderType" => "文件夹",
                "FileDialogs_FileName" => "文件名：",
                "FileDialogs_FileNameWrongCharacters" => @"文件名不能包含以下任何字符：\ /：*？ \“ <>",
                "FileDialogs_FileSizes_B" => "bytes",
                "FileDialogs_FileSizes_GB" => "GB",
                "FileDialogs_FileSizes_KB" => "KB",
                "FileDialogs_FileSizes_MB" => "MB",
                "FileDialogs_FileSizes_TB" => "TB",
                "FileDialogs_Folder" => "文件夹：",
                "FileDialogs_Forward" => "方向",
                "FileDialogs_InvalidExtensionConfirmation" => "您确定要更改吗？",
                "FileDialogs_InvalidFileName" => "文件名无效。",
                "FileDialogs_InvalidOrMissingExtension" => "如果更改文件扩展名，则该文件可能变得无法使用。",
                "FileDialogs_InvalidPath" => "路径不存在。",
                "FileDialogs_LargeIcons" => "大图标",
                "FileDialogs_List" => "列表",
                "FileDialogs_MediumIcons" => "中图标",
                "FileDialogs_MoveTo" => "移动到",
                "FileDialogs_NameHeader" => "名称",
                "FileDialogs_NewFolder" => "新建文件夹",
                "FileDialogs_No" => "否",
                "FileDialogs_OK" => "确定",
                "FileDialogs_Open" => "打开",
                "FileDialogs_OpenFileDialogHeader" => "打开文件",
                "FileDialogs_OpenFolder" => "打开目录",
                "FileDialogs_OpenFolderDialogHeader" => "打开目录",
                "FileDialogs_OpenReadOnly" => "以只读方式打开",
                "FileDialogs_Paste" => "粘贴",
                "FileDialogs_Properties" => "属性",
                "FileDialogs_Rename" => "重命名",
                "FileDialogs_ReplacementQuestion" => "真的要替换它吗？",
                "FileDialogs_Save" => "保存",
                "FileDialogs_SaveAsType" => "保存类型：",
                "FileDialogs_SaveFileDialogHeader" => "另存为",
                "FileDialogs_SearchIn" => "搜索",
                "FileDialogs_SearchResults" => "搜索结果",
                "FileDialogs_SizeHeader" => "大小",
                "FileDialogs_SmallIcons" => "小图标",
                "FileDialogs_Tiles" => "标题",
                "FileDialogs_TypeHeader" => "类型",
                "FileDialogs_Up" => "上移",
                "FileDialogs_View" => "视图",
                "FileDialogs_Yes" => "是",
                "GridViewAlwaysVisibleNewRow" => "点击这里添加新项",
                "GridViewClearFilter" => "清除筛选",
                "GridViewFilter" => "筛选",
                "GridViewFilterAnd" => "并且",
                "GridViewFilterContains" => "包含",
                "GridViewFilterDoesNotContain" => "不包含于",
                "GridViewFilterEndsWith" => "结尾等于",
                "GridViewFilterIsContainedIn" => "包含在",
                "GridViewFilterIsEqualTo" => "等于",
                "GridViewFilterIsGreaterThan" => "大于",
                "GridViewFilterIsGreaterThanOrEqualTo" => "大于等于",
                "GridViewFilterIsLessThan" => "小于",
                "GridViewFilterIsLessThanOrEqualTo" => "小于等于",
                "GridViewFilterIsNotContainedIn" => "不包含在",
                "GridViewFilterIsNotEqualTo" => "不等于",
                "GridViewFilterMatch" => "区分大小写",
                "GridViewFilterOr" => "或",
                "GridViewFilterSelectAll" => "全选",
                "GridViewFilterShowRowsWithValueThat" => "显示在行中的值",
                "GridViewFilterStartsWith" => "开头等于",
                "GridViewGroupPanelText" => "拖拽一列放在这里进行分组",
                "GridViewGroupPanelTopText" => "组",
                "GridViewGroupPanelTopTextGrouped" => "分组于",
                "Minimize" => "最小化",
                "RibbonViewExpandRibbon" => "展开功能区",
                "RibbonViewGalleryButtonMore" => "更多",
                "RibbonViewGalleryButtonUpDown" => "行",
                "RibbonViewHelp" => "帮助",
                "RibbonViewLayoutModeButtonContent" => "简化功能区",
                "RibbonViewQATCustomize" => "自定义快速访问工具栏",
                "RibbonViewQATMinimize" => "最小化功能区",
                "RibbonViewQATRestore" => "恢复功能区",
                "RibbonViewQATShowAbove" => "显示在功能区上方",
                "RibbonViewQATShowBelow" => "显示在功能区下方",
                "RibbonWindowClose" => "关闭",
                "RibbonWindowMaximize" => "最大化",
                "RibbonWindowMinimize" => "最小化",
                "RibbonWindowRestoreDown" => "还原",
                "Hide" => "隐藏",
                "Auto_hide" => "自动隐藏",
                "Floating" => "浮动",
                "Dockable" => "停靠",
                "GridViewColumnsSelectionButtonTooltip" => "选择列",
                "Tabbed_document" => "作为选项卡式文档停靠",
                "SelectAll" => "全选",
                "UnselectAll" => "全部取消选择",
                "ToggleSelectAll" => "反选",
                "Ok" => "确定",
                "Close" => "关闭",
                "Cancel" => "取消",
                "Restore" => "还原",
                "Maximize" => "最大化",
                "Clear" => "清除",
                "CommitEdit" => "提交编辑",
                "Copy" => "复制",
                "Paste" => "粘贴",
                "Search" => "查找",
                "Delete" => "删除",
                _ => this.GetStringWithLog(key),
            };
        }
    }
}
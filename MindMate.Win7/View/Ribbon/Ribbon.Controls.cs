﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using MindMate.View.EditorTabs;
using MindMate.View.MapControls;
using RibbonLib;
using RibbonLib.Controls;

namespace MindMate.View.Ribbon
{
	public partial class Ribbon
    {
		private RibbonApplicationMenu ApplicationMenu;		
		private RibbonRecentItems RecentItems;		
		private RibbonButton ButtonNew;		
		private RibbonButton ButtonOpen;		
		private RibbonButton ButtonSave;		
		private RibbonButton SaveAs;		
		private RibbonButton SaveAll;		
		private RibbonDropDownButton Export;		
		private RibbonButton ExportAsPNG;		
		private RibbonButton ExportAsJPG;		
		private RibbonButton Close;		
		private RibbonButton ButtonExit;		
		private RibbonTab TabHome;		
		private RibbonGroup NewNode;		
		private RibbonButton NewChildNode;		
		private RibbonButton NewLongNode;		
		private RibbonButton NewNodeAbove;		
		private RibbonButton NewNodeBelow;		
		private RibbonButton NewNodeParent;		
		private RibbonGroup GrpEdit;		
		private RibbonButton EditText;		
		private RibbonButton EditLong;		
		private RibbonButton DeleteNode;		
		private RibbonGroup GrpClipboard;		
		private RibbonButton Paste;		
		private RibbonButton PasteAsText;		
		private RibbonButton Cut;		
		private RibbonButton Copy;		
		private RibbonToggleButton FormatPainter;		
		private RibbonGroup GrpFont;		
		private RibbonFontControl RichFont;		
		private RibbonGroup GrpIcons;		
		private RibbonInRibbonGallery IconsGallery;		
		private RibbonButton RemoveLastIcon;		
		private RibbonButton RemoveAllIcons;		
		private RibbonButton LaunchIconsDialog;		
		private RibbonTab TabEdit;		
		private RibbonGroup GrpSelect;		
		private RibbonButton SelectAll;		
		private RibbonButton SelectSiblings;		
		private RibbonButton SelectAncestors;		
		private RibbonButton SelectChildren;		
		private RibbonButton SelectDescendents;		
		private RibbonButton SelectDescendentsUpto1;		
		private RibbonButton SelectDescendentsUpto2;		
		private RibbonButton SelectDescendentsUpto3;		
		private RibbonButton SelectDescendentsUpto4;		
		private RibbonButton SelectDescendentsUpto5;		
		private RibbonCheckBox ExpandOnSelect;		
		private RibbonDropDownButton SelectLevel;		
		private RibbonButton SelectLevel1;		
		private RibbonButton SelectLevel2;		
		private RibbonButton SelectLevel3;		
		private RibbonButton SelectLevel4;		
		private RibbonButton SelectLevel5;		
		private RibbonButton SelectLevelCurrent;		
		private RibbonGroup GrpExpand;		
		private RibbonButton ExpandAll;		
		private RibbonButton CollapseAll;		
		private RibbonButton ToggleCurrent;		
		private RibbonButton ToggleBranch;		
		private RibbonButton ExpandMapToCurrentLevel;		
		private RibbonButton ExpandMapToLevel1;		
		private RibbonButton ExpandMapToLevel2;		
		private RibbonButton ExpandMapToLevel3;		
		private RibbonButton ExpandMapToLevel4;		
		private RibbonButton ExpandMapToLevel5;		

		private void InitializeComponents()
		{
			// Instantiate Controls
			ApplicationMenu = new RibbonApplicationMenu(ribbon, (uint)RibbonMarkupCommands.ApplicationMenu);
			RecentItems = new RibbonRecentItems(ribbon, (uint)RibbonMarkupCommands.RecentItems);
			ButtonNew = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.ButtonNew);
			ButtonOpen = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.ButtonOpen);
			ButtonSave = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.ButtonSave);
			SaveAs = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.SaveAs);
			SaveAll = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.SaveAll);
			Export = new RibbonDropDownButton(ribbon, (uint)RibbonMarkupCommands.Export);
			ExportAsPNG = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.ExportAsPNG);
			ExportAsJPG = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.ExportAsJPG);
			Close = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.Close);
			ButtonExit = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.ButtonExit);
			TabHome = new RibbonTab(ribbon, (uint)RibbonMarkupCommands.TabHome);
			NewNode = new RibbonGroup(ribbon, (uint)RibbonMarkupCommands.NewNode);
			NewChildNode = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.NewChildNode);
			NewLongNode = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.NewLongNode);
			NewNodeAbove = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.NewNodeAbove);
			NewNodeBelow = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.NewNodeBelow);
			NewNodeParent = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.NewNodeParent);
			GrpEdit = new RibbonGroup(ribbon, (uint)RibbonMarkupCommands.GrpEdit);
			EditText = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.EditText);
			EditLong = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.EditLong);
			DeleteNode = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.DeleteNode);
			GrpClipboard = new RibbonGroup(ribbon, (uint)RibbonMarkupCommands.GrpClipboard);
			Paste = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.Paste);
			PasteAsText = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.PasteAsText);
			Cut = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.Cut);
			Copy = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.Copy);
			FormatPainter = new RibbonToggleButton(ribbon, (uint)RibbonMarkupCommands.FormatPainter);
			GrpFont = new RibbonGroup(ribbon, (uint)RibbonMarkupCommands.GrpFont);
			RichFont = new RibbonFontControl(ribbon, (uint)RibbonMarkupCommands.RichFont);
			GrpIcons = new RibbonGroup(ribbon, (uint)RibbonMarkupCommands.GrpIcons);
			IconsGallery = new RibbonInRibbonGallery(ribbon, (uint)RibbonMarkupCommands.IconsGallery);
			RemoveLastIcon = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.RemoveLastIcon);
			RemoveAllIcons = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.RemoveAllIcons);
			LaunchIconsDialog = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.LaunchIconsDialog);
			TabEdit = new RibbonTab(ribbon, (uint)RibbonMarkupCommands.TabEdit);
			GrpSelect = new RibbonGroup(ribbon, (uint)RibbonMarkupCommands.GrpSelect);
			SelectAll = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.SelectAll);
			SelectSiblings = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.SelectSiblings);
			SelectAncestors = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.SelectAncestors);
			SelectChildren = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.SelectChildren);
			SelectDescendents = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.SelectDescendents);
			SelectDescendentsUpto1 = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.SelectDescendentsUpto1);
			SelectDescendentsUpto2 = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.SelectDescendentsUpto2);
			SelectDescendentsUpto3 = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.SelectDescendentsUpto3);
			SelectDescendentsUpto4 = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.SelectDescendentsUpto4);
			SelectDescendentsUpto5 = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.SelectDescendentsUpto5);
			ExpandOnSelect = new RibbonCheckBox(ribbon, (uint)RibbonMarkupCommands.ExpandOnSelect);
			SelectLevel = new RibbonDropDownButton(ribbon, (uint)RibbonMarkupCommands.SelectLevel);
			SelectLevel1 = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.SelectLevel1);
			SelectLevel2 = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.SelectLevel2);
			SelectLevel3 = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.SelectLevel3);
			SelectLevel4 = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.SelectLevel4);
			SelectLevel5 = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.SelectLevel5);
			SelectLevelCurrent = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.SelectLevelCurrent);
			GrpExpand = new RibbonGroup(ribbon, (uint)RibbonMarkupCommands.GrpExpand);
			ExpandAll = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.ExpandAll);
			CollapseAll = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.CollapseAll);
			ToggleCurrent = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.ToggleCurrent);
			ToggleBranch = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.ToggleBranch);
			ExpandMapToCurrentLevel = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.ExpandMapToCurrentLevel);
			ExpandMapToLevel1 = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.ExpandMapToLevel1);
			ExpandMapToLevel2 = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.ExpandMapToLevel2);
			ExpandMapToLevel3 = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.ExpandMapToLevel3);
			ExpandMapToLevel4 = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.ExpandMapToLevel4);
			ExpandMapToLevel5 = new RibbonButton(ribbon, (uint)RibbonMarkupCommands.ExpandMapToLevel5);

		}
	
	}
}



// This file has been generated by the GUI designer. Do not modify.
namespace MonoDevelop.PlayScript.Formatting
{
	public partial class CSharpFormattingProfileDialog
	{
		private global::Gtk.VBox vbox5;
		private global::Gtk.HPaned hpaned1;
		private global::Gtk.VBox vbox2;
		private global::Gtk.HBox hbox4;
		private global::Gtk.Label label12;
		private global::Gtk.ComboBox comboboxCategories;
		private global::Gtk.Notebook notebookCategories;
		private global::Gtk.VBox vbox8;
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		private global::Gtk.TreeView treeviewIndentOptions;
		private global::Gtk.Label label8;
		private global::Gtk.ScrolledWindow GtkScrolledWindow1;
		private global::Gtk.TreeView treeviewBracePositions;
		private global::Gtk.Label label9;
		private global::Gtk.Table table4;
		private global::Gtk.Entry entryAfterUsings;
		private global::Gtk.Entry entryBeforeFirstDeclaration;
		private global::Gtk.Entry entryBeforUsings;
		private global::Gtk.Entry entryBetweenEvents;
		private global::Gtk.Entry entryBetweenFields;
		private global::Gtk.Entry entryBetweenMembers;
		private global::Gtk.Entry entryBetweenTypes;
		private global::Gtk.Label GtkLabel8;
		private global::Gtk.Label GtkLabel9;
		private global::Gtk.Label label1;
		private global::Gtk.Label label15;
		private global::Gtk.Label label16;
		private global::Gtk.Label label19;
		private global::Gtk.Label label20;
		private global::Gtk.Label label21;
		private global::Gtk.Label label22;
		private global::Gtk.Label label23;
		private global::Gtk.Label label14;
		private global::Gtk.ScrolledWindow GtkScrolledWindow2;
		private global::Gtk.TreeView treeviewInsertWhiteSpaceCategory;
		private global::Gtk.Label label10;
		private global::Gtk.ScrolledWindow GtkScrolledWindow4;
		private global::Gtk.TreeView treeviewNewLines;
		private global::Gtk.Label label11;
		private global::Gtk.VBox vbox6;
		private global::Gtk.Label label13;
		private global::Gtk.ScrolledWindow scrolledwindow;
		private global::Gtk.Button buttonCancel;
		private global::Gtk.Button buttonOk;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget MonoDevelop.PlayScript.Formatting.CSharpFormattingProfileDialog
			this.Name = "MonoDevelop.PlayScript.Formatting.CSharpFormattingProfileDialog";
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.BorderWidth = ((uint)(6));
			// Internal child MonoDevelop.PlayScript.Formatting.CSharpFormattingProfileDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.Spacing = 6;
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.vbox5 = new global::Gtk.VBox ();
			this.vbox5.Name = "vbox5";
			this.vbox5.Spacing = 6;
			// Container child vbox5.Gtk.Box+BoxChild
			this.hpaned1 = new global::Gtk.HPaned ();
			this.hpaned1.CanFocus = true;
			this.hpaned1.Name = "hpaned1";
			this.hpaned1.Position = 424;
			// Container child hpaned1.Gtk.Paned+PanedChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox ();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.label12 = new global::Gtk.Label ();
			this.label12.Name = "label12";
			this.label12.LabelProp = global::Mono.Unix.Catalog.GetString ("_Category:");
			this.label12.UseUnderline = true;
			this.hbox4.Add (this.label12);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.label12]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.comboboxCategories = global::Gtk.ComboBox.NewText ();
			this.comboboxCategories.Name = "comboboxCategories";
			this.hbox4.Add (this.comboboxCategories);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.comboboxCategories]));
			w3.Position = 1;
			this.vbox2.Add (this.hbox4);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox4]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.notebookCategories = new global::Gtk.Notebook ();
			this.notebookCategories.CanFocus = true;
			this.notebookCategories.Name = "notebookCategories";
			this.notebookCategories.CurrentPage = 3;
			// Container child notebookCategories.Gtk.Notebook+NotebookChild
			this.vbox8 = new global::Gtk.VBox ();
			this.vbox8.Name = "vbox8";
			this.vbox8.Spacing = 6;
			// Container child vbox8.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.treeviewIndentOptions = new global::Gtk.TreeView ();
			this.treeviewIndentOptions.CanFocus = true;
			this.treeviewIndentOptions.Name = "treeviewIndentOptions";
			this.GtkScrolledWindow.Add (this.treeviewIndentOptions);
			this.vbox8.Add (this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox8 [this.GtkScrolledWindow]));
			w6.Position = 0;
			this.notebookCategories.Add (this.vbox8);
			// Notebook tab
			this.label8 = new global::Gtk.Label ();
			this.label8.Name = "label8";
			this.label8.LabelProp = global::Mono.Unix.Catalog.GetString ("page1");
			this.notebookCategories.SetTabLabel (this.vbox8, this.label8);
			this.label8.ShowAll ();
			// Container child notebookCategories.Gtk.Notebook+NotebookChild
			this.GtkScrolledWindow1 = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow1.Name = "GtkScrolledWindow1";
			this.GtkScrolledWindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow1.Gtk.Container+ContainerChild
			this.treeviewBracePositions = new global::Gtk.TreeView ();
			this.treeviewBracePositions.CanFocus = true;
			this.treeviewBracePositions.Name = "treeviewBracePositions";
			this.GtkScrolledWindow1.Add (this.treeviewBracePositions);
			this.notebookCategories.Add (this.GtkScrolledWindow1);
			global::Gtk.Notebook.NotebookChild w9 = ((global::Gtk.Notebook.NotebookChild)(this.notebookCategories [this.GtkScrolledWindow1]));
			w9.Position = 1;
			// Notebook tab
			this.label9 = new global::Gtk.Label ();
			this.label9.Name = "label9";
			this.label9.LabelProp = global::Mono.Unix.Catalog.GetString ("page2");
			this.notebookCategories.SetTabLabel (this.GtkScrolledWindow1, this.label9);
			this.label9.ShowAll ();
			// Container child notebookCategories.Gtk.Notebook+NotebookChild
			this.table4 = new global::Gtk.Table (((uint)(10)), ((uint)(2)), false);
			this.table4.Name = "table4";
			this.table4.RowSpacing = ((uint)(6));
			this.table4.ColumnSpacing = ((uint)(6));
			// Container child table4.Gtk.Table+TableChild
			this.entryAfterUsings = new global::Gtk.Entry ();
			this.entryAfterUsings.CanFocus = true;
			this.entryAfterUsings.Name = "entryAfterUsings";
			this.entryAfterUsings.IsEditable = true;
			this.entryAfterUsings.InvisibleChar = '●';
			this.table4.Add (this.entryAfterUsings);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table4 [this.entryAfterUsings]));
			w10.TopAttach = ((uint)(2));
			w10.BottomAttach = ((uint)(3));
			w10.LeftAttach = ((uint)(1));
			w10.RightAttach = ((uint)(2));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.entryBeforeFirstDeclaration = new global::Gtk.Entry ();
			this.entryBeforeFirstDeclaration.CanFocus = true;
			this.entryBeforeFirstDeclaration.Name = "entryBeforeFirstDeclaration";
			this.entryBeforeFirstDeclaration.IsEditable = true;
			this.entryBeforeFirstDeclaration.InvisibleChar = '●';
			this.table4.Add (this.entryBeforeFirstDeclaration);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table4 [this.entryBeforeFirstDeclaration]));
			w11.TopAttach = ((uint)(4));
			w11.BottomAttach = ((uint)(5));
			w11.LeftAttach = ((uint)(1));
			w11.RightAttach = ((uint)(2));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.entryBeforUsings = new global::Gtk.Entry ();
			this.entryBeforUsings.CanFocus = true;
			this.entryBeforUsings.Name = "entryBeforUsings";
			this.entryBeforUsings.IsEditable = true;
			this.entryBeforUsings.InvisibleChar = '●';
			this.table4.Add (this.entryBeforUsings);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table4 [this.entryBeforUsings]));
			w12.TopAttach = ((uint)(1));
			w12.BottomAttach = ((uint)(2));
			w12.LeftAttach = ((uint)(1));
			w12.RightAttach = ((uint)(2));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.entryBetweenEvents = new global::Gtk.Entry ();
			this.entryBetweenEvents.CanFocus = true;
			this.entryBetweenEvents.Name = "entryBetweenEvents";
			this.entryBetweenEvents.IsEditable = true;
			this.entryBetweenEvents.InvisibleChar = '●';
			this.table4.Add (this.entryBetweenEvents);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table4 [this.entryBetweenEvents]));
			w13.TopAttach = ((uint)(8));
			w13.BottomAttach = ((uint)(9));
			w13.LeftAttach = ((uint)(1));
			w13.RightAttach = ((uint)(2));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.entryBetweenFields = new global::Gtk.Entry ();
			this.entryBetweenFields.CanFocus = true;
			this.entryBetweenFields.Name = "entryBetweenFields";
			this.entryBetweenFields.IsEditable = true;
			this.entryBetweenFields.InvisibleChar = '●';
			this.table4.Add (this.entryBetweenFields);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.table4 [this.entryBetweenFields]));
			w14.TopAttach = ((uint)(7));
			w14.BottomAttach = ((uint)(8));
			w14.LeftAttach = ((uint)(1));
			w14.RightAttach = ((uint)(2));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.entryBetweenMembers = new global::Gtk.Entry ();
			this.entryBetweenMembers.CanFocus = true;
			this.entryBetweenMembers.Name = "entryBetweenMembers";
			this.entryBetweenMembers.IsEditable = true;
			this.entryBetweenMembers.InvisibleChar = '●';
			this.table4.Add (this.entryBetweenMembers);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.table4 [this.entryBetweenMembers]));
			w15.TopAttach = ((uint)(9));
			w15.BottomAttach = ((uint)(10));
			w15.LeftAttach = ((uint)(1));
			w15.RightAttach = ((uint)(2));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.entryBetweenTypes = new global::Gtk.Entry ();
			this.entryBetweenTypes.CanFocus = true;
			this.entryBetweenTypes.Name = "entryBetweenTypes";
			this.entryBetweenTypes.IsEditable = true;
			this.entryBetweenTypes.InvisibleChar = '●';
			this.table4.Add (this.entryBetweenTypes);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.table4 [this.entryBetweenTypes]));
			w16.TopAttach = ((uint)(5));
			w16.BottomAttach = ((uint)(6));
			w16.LeftAttach = ((uint)(1));
			w16.RightAttach = ((uint)(2));
			w16.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.GtkLabel8 = new global::Gtk.Label ();
			this.GtkLabel8.Name = "GtkLabel8";
			this.GtkLabel8.Xalign = 0F;
			this.GtkLabel8.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Blank lines in namespaces</b>");
			this.GtkLabel8.UseMarkup = true;
			this.table4.Add (this.GtkLabel8);
			global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.table4 [this.GtkLabel8]));
			w17.TopAttach = ((uint)(3));
			w17.BottomAttach = ((uint)(4));
			w17.XOptions = ((global::Gtk.AttachOptions)(4));
			w17.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.GtkLabel9 = new global::Gtk.Label ();
			this.GtkLabel9.Name = "GtkLabel9";
			this.GtkLabel9.Xalign = 0F;
			this.GtkLabel9.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Blank lines in types</b>");
			this.GtkLabel9.UseMarkup = true;
			this.table4.Add (this.GtkLabel9);
			global::Gtk.Table.TableChild w18 = ((global::Gtk.Table.TableChild)(this.table4 [this.GtkLabel9]));
			w18.TopAttach = ((uint)(6));
			w18.BottomAttach = ((uint)(7));
			w18.XOptions = ((global::Gtk.AttachOptions)(4));
			w18.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.Xalign = 0F;
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Blank lines in compilation unit</b>");
			this.label1.UseMarkup = true;
			this.table4.Add (this.label1);
			global::Gtk.Table.TableChild w19 = ((global::Gtk.Table.TableChild)(this.table4 [this.label1]));
			w19.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.label15 = new global::Gtk.Label ();
			this.label15.Name = "label15";
			this.label15.Xalign = 1F;
			this.label15.LabelProp = global::Mono.Unix.Catalog.GetString ("Before using declaration:");
			this.table4.Add (this.label15);
			global::Gtk.Table.TableChild w20 = ((global::Gtk.Table.TableChild)(this.table4 [this.label15]));
			w20.TopAttach = ((uint)(1));
			w20.BottomAttach = ((uint)(2));
			w20.XOptions = ((global::Gtk.AttachOptions)(4));
			w20.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.label16 = new global::Gtk.Label ();
			this.label16.Name = "label16";
			this.label16.Xalign = 1F;
			this.label16.LabelProp = global::Mono.Unix.Catalog.GetString ("After using declaration:");
			this.table4.Add (this.label16);
			global::Gtk.Table.TableChild w21 = ((global::Gtk.Table.TableChild)(this.table4 [this.label16]));
			w21.TopAttach = ((uint)(2));
			w21.BottomAttach = ((uint)(3));
			w21.XOptions = ((global::Gtk.AttachOptions)(4));
			w21.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.label19 = new global::Gtk.Label ();
			this.label19.Name = "label19";
			this.label19.Xalign = 1F;
			this.label19.LabelProp = global::Mono.Unix.Catalog.GetString ("Between type declarations:");
			this.table4.Add (this.label19);
			global::Gtk.Table.TableChild w22 = ((global::Gtk.Table.TableChild)(this.table4 [this.label19]));
			w22.TopAttach = ((uint)(5));
			w22.BottomAttach = ((uint)(6));
			w22.XOptions = ((global::Gtk.AttachOptions)(4));
			w22.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.label20 = new global::Gtk.Label ();
			this.label20.Name = "label20";
			this.label20.Xalign = 1F;
			this.label20.LabelProp = global::Mono.Unix.Catalog.GetString ("Before first declaration:");
			this.table4.Add (this.label20);
			global::Gtk.Table.TableChild w23 = ((global::Gtk.Table.TableChild)(this.table4 [this.label20]));
			w23.TopAttach = ((uint)(4));
			w23.BottomAttach = ((uint)(5));
			w23.XOptions = ((global::Gtk.AttachOptions)(4));
			w23.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.label21 = new global::Gtk.Label ();
			this.label21.Name = "label21";
			this.label21.Xalign = 1F;
			this.label21.LabelProp = global::Mono.Unix.Catalog.GetString ("Between field declarations:");
			this.table4.Add (this.label21);
			global::Gtk.Table.TableChild w24 = ((global::Gtk.Table.TableChild)(this.table4 [this.label21]));
			w24.TopAttach = ((uint)(7));
			w24.BottomAttach = ((uint)(8));
			w24.XOptions = ((global::Gtk.AttachOptions)(4));
			w24.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.label22 = new global::Gtk.Label ();
			this.label22.Name = "label22";
			this.label22.Xalign = 1F;
			this.label22.LabelProp = global::Mono.Unix.Catalog.GetString ("Between other member declarations:");
			this.table4.Add (this.label22);
			global::Gtk.Table.TableChild w25 = ((global::Gtk.Table.TableChild)(this.table4 [this.label22]));
			w25.TopAttach = ((uint)(9));
			w25.BottomAttach = ((uint)(10));
			w25.XOptions = ((global::Gtk.AttachOptions)(4));
			w25.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table4.Gtk.Table+TableChild
			this.label23 = new global::Gtk.Label ();
			this.label23.Name = "label23";
			this.label23.Xalign = 1F;
			this.label23.LabelProp = global::Mono.Unix.Catalog.GetString ("Between simple event declarations:");
			this.table4.Add (this.label23);
			global::Gtk.Table.TableChild w26 = ((global::Gtk.Table.TableChild)(this.table4 [this.label23]));
			w26.TopAttach = ((uint)(8));
			w26.BottomAttach = ((uint)(9));
			w26.XOptions = ((global::Gtk.AttachOptions)(4));
			w26.YOptions = ((global::Gtk.AttachOptions)(4));
			this.notebookCategories.Add (this.table4);
			global::Gtk.Notebook.NotebookChild w27 = ((global::Gtk.Notebook.NotebookChild)(this.notebookCategories [this.table4]));
			w27.Position = 2;
			// Notebook tab
			this.label14 = new global::Gtk.Label ();
			this.label14.Name = "label14";
			this.label14.LabelProp = global::Mono.Unix.Catalog.GetString ("page5");
			this.notebookCategories.SetTabLabel (this.table4, this.label14);
			this.label14.ShowAll ();
			// Container child notebookCategories.Gtk.Notebook+NotebookChild
			this.GtkScrolledWindow2 = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow2.Name = "GtkScrolledWindow2";
			this.GtkScrolledWindow2.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow2.Gtk.Container+ContainerChild
			this.treeviewInsertWhiteSpaceCategory = new global::Gtk.TreeView ();
			this.treeviewInsertWhiteSpaceCategory.CanFocus = true;
			this.treeviewInsertWhiteSpaceCategory.Name = "treeviewInsertWhiteSpaceCategory";
			this.GtkScrolledWindow2.Add (this.treeviewInsertWhiteSpaceCategory);
			this.notebookCategories.Add (this.GtkScrolledWindow2);
			global::Gtk.Notebook.NotebookChild w29 = ((global::Gtk.Notebook.NotebookChild)(this.notebookCategories [this.GtkScrolledWindow2]));
			w29.Position = 3;
			// Notebook tab
			this.label10 = new global::Gtk.Label ();
			this.label10.Name = "label10";
			this.label10.LabelProp = global::Mono.Unix.Catalog.GetString ("page3");
			this.notebookCategories.SetTabLabel (this.GtkScrolledWindow2, this.label10);
			this.label10.ShowAll ();
			// Container child notebookCategories.Gtk.Notebook+NotebookChild
			this.GtkScrolledWindow4 = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow4.Name = "GtkScrolledWindow4";
			this.GtkScrolledWindow4.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow4.Gtk.Container+ContainerChild
			this.treeviewNewLines = new global::Gtk.TreeView ();
			this.treeviewNewLines.CanFocus = true;
			this.treeviewNewLines.Name = "treeviewNewLines";
			this.GtkScrolledWindow4.Add (this.treeviewNewLines);
			this.notebookCategories.Add (this.GtkScrolledWindow4);
			global::Gtk.Notebook.NotebookChild w31 = ((global::Gtk.Notebook.NotebookChild)(this.notebookCategories [this.GtkScrolledWindow4]));
			w31.Position = 4;
			// Notebook tab
			this.label11 = new global::Gtk.Label ();
			this.label11.Name = "label11";
			this.label11.LabelProp = global::Mono.Unix.Catalog.GetString ("page4");
			this.notebookCategories.SetTabLabel (this.GtkScrolledWindow4, this.label11);
			this.label11.ShowAll ();
			this.vbox2.Add (this.notebookCategories);
			global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.notebookCategories]));
			w32.Position = 1;
			this.hpaned1.Add (this.vbox2);
			global::Gtk.Paned.PanedChild w33 = ((global::Gtk.Paned.PanedChild)(this.hpaned1 [this.vbox2]));
			w33.Resize = false;
			// Container child hpaned1.Gtk.Paned+PanedChild
			this.vbox6 = new global::Gtk.VBox ();
			this.vbox6.Name = "vbox6";
			this.vbox6.Spacing = 6;
			// Container child vbox6.Gtk.Box+BoxChild
			this.label13 = new global::Gtk.Label ();
			this.label13.Name = "label13";
			this.label13.Xalign = 0F;
			this.label13.LabelProp = global::Mono.Unix.Catalog.GetString ("Preview:");
			this.vbox6.Add (this.label13);
			global::Gtk.Box.BoxChild w34 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this.label13]));
			w34.Position = 0;
			w34.Expand = false;
			w34.Fill = false;
			// Container child vbox6.Gtk.Box+BoxChild
			this.scrolledwindow = new global::Gtk.ScrolledWindow ();
			this.scrolledwindow.CanFocus = true;
			this.scrolledwindow.Name = "scrolledwindow";
			this.scrolledwindow.ShadowType = ((global::Gtk.ShadowType)(1));
			this.vbox6.Add (this.scrolledwindow);
			global::Gtk.Box.BoxChild w35 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this.scrolledwindow]));
			w35.Position = 1;
			this.hpaned1.Add (this.vbox6);
			this.vbox5.Add (this.hpaned1);
			global::Gtk.Box.BoxChild w37 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.hpaned1]));
			w37.Position = 0;
			w1.Add (this.vbox5);
			global::Gtk.Box.BoxChild w38 = ((global::Gtk.Box.BoxChild)(w1 [this.vbox5]));
			w38.Position = 0;
			// Internal child MonoDevelop.PlayScript.Formatting.CSharpFormattingProfileDialog.ActionArea
			global::Gtk.HButtonBox w39 = this.ActionArea;
			w39.Name = "dialog1_ActionArea";
			w39.Spacing = 10;
			w39.BorderWidth = ((uint)(5));
			w39.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseStock = true;
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = "gtk-cancel";
			this.AddActionWidget (this.buttonCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w40 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w39 [this.buttonCancel]));
			w40.Expand = false;
			w40.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseStock = true;
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "gtk-ok";
			this.AddActionWidget (this.buttonOk, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w41 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w39 [this.buttonOk]));
			w41.Position = 1;
			w41.Expand = false;
			w41.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 880;
			this.DefaultHeight = 551;
			this.Hide ();
		}
	}
}

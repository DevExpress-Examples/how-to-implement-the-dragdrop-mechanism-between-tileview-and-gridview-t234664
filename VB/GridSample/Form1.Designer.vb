﻿Namespace GridSample
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim tileViewItemElement1 As New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
			Dim tileViewItemElement2 As New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
			Dim tileViewItemElement3 As New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
			Dim tileViewItemElement4 As New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
			Me.tileViewColumn1 = New DevExpress.XtraGrid.Columns.TileViewColumn()
			Me.tileViewColumn2 = New DevExpress.XtraGrid.Columns.TileViewColumn()
			Me.tileViewColumn3 = New DevExpress.XtraGrid.Columns.TileViewColumn()
			Me.tileViewColumn4 = New DevExpress.XtraGrid.Columns.TileViewColumn()
			Me.splitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.tileView1 = New DevExpress.XtraGrid.Views.Tile.TileView()
			Me.gridControl2 = New DevExpress.XtraGrid.GridControl()
			Me.gridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.behaviorManager1 = New DevExpress.Utils.Behaviors.BehaviorManager(Me.components)
			Me.dragDropEvents1 = New DevExpress.Utils.DragDrop.DragDropEvents(Me.components)
			Me.dragDropEvents2 = New DevExpress.Utils.DragDrop.DragDropEvents(Me.components)
			CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.splitContainerControl1.SuspendLayout()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.tileView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.behaviorManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' tileViewColumn1
			' 
			Me.tileViewColumn1.Caption = "tileViewColumn1"
			Me.tileViewColumn1.FieldName = "Dosage"
			Me.tileViewColumn1.MinWidth = 17
			Me.tileViewColumn1.Name = "tileViewColumn1"
			Me.tileViewColumn1.Visible = True
			Me.tileViewColumn1.VisibleIndex = 0
			Me.tileViewColumn1.Width = 64
			' 
			' tileViewColumn2
			' 
			Me.tileViewColumn2.Caption = "tileViewColumn2"
			Me.tileViewColumn2.FieldName = "Drug"
			Me.tileViewColumn2.MinWidth = 17
			Me.tileViewColumn2.Name = "tileViewColumn2"
			Me.tileViewColumn2.Visible = True
			Me.tileViewColumn2.VisibleIndex = 1
			Me.tileViewColumn2.Width = 64
			' 
			' tileViewColumn3
			' 
			Me.tileViewColumn3.Caption = "tileViewColumn3"
			Me.tileViewColumn3.FieldName = "Patient"
			Me.tileViewColumn3.MinWidth = 17
			Me.tileViewColumn3.Name = "tileViewColumn3"
			Me.tileViewColumn3.Visible = True
			Me.tileViewColumn3.VisibleIndex = 2
			Me.tileViewColumn3.Width = 64
			' 
			' tileViewColumn4
			' 
			Me.tileViewColumn4.Caption = "tileViewColumn4"
			Me.tileViewColumn4.FieldName = "Date"
			Me.tileViewColumn4.MinWidth = 17
			Me.tileViewColumn4.Name = "tileViewColumn4"
			Me.tileViewColumn4.Visible = True
			Me.tileViewColumn4.VisibleIndex = 3
			Me.tileViewColumn4.Width = 64
			' 
			' splitContainerControl1
			' 
			Me.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.splitContainerControl1.Location = New System.Drawing.Point(0, 0)
			Me.splitContainerControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
			Me.splitContainerControl1.Name = "splitContainerControl1"
			Me.splitContainerControl1.Panel1.Controls.Add(Me.gridControl1)
			Me.splitContainerControl1.Panel1.Text = "Panel1"
			Me.splitContainerControl1.Panel2.Controls.Add(Me.gridControl2)
			Me.splitContainerControl1.Panel2.Text = "Panel2"
			Me.splitContainerControl1.Size = New System.Drawing.Size(1066, 374)
			Me.splitContainerControl1.SplitterPosition = 528
			Me.splitContainerControl1.TabIndex = 0
			Me.splitContainerControl1.Text = "splitContainerControl1"
			' 
			' gridControl1
			' 
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.tileView1
			Me.gridControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(528, 374)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.tileView1})
			' 
			' tileView1
			' 
			Me.tileView1.Appearance.ItemHovered.BackColor = System.Drawing.Color.Red
			Me.tileView1.Appearance.ItemHovered.Options.UseBackColor = True
			Me.tileView1.Appearance.ItemNormal.BackColor = System.Drawing.Color.Gainsboro
			Me.tileView1.Appearance.ItemNormal.Options.UseBackColor = True
			Me.behaviorManager1.SetBehaviors(Me.tileView1, New DevExpress.Utils.Behaviors.Behavior() { (CType(DevExpress.Utils.DragDrop.DragDropBehavior.Create(GetType(DevExpress.XtraGrid.Extensions.ColumnViewDragDropSource), True, True, True, True, Me.dragDropEvents1), DevExpress.Utils.Behaviors.Behavior))})
			Me.tileView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.tileViewColumn1, Me.tileViewColumn2, Me.tileViewColumn3, Me.tileViewColumn4})
			Me.tileView1.DetailHeight = 284
			Me.tileView1.GridControl = Me.gridControl1
			Me.tileView1.Name = "tileView1"
			Me.tileView1.OptionsBehavior.AllowMousePanning = False
			tileViewItemElement1.Column = Me.tileViewColumn1
			tileViewItemElement1.Text = "tileViewColumn1"
			tileViewItemElement2.Column = Me.tileViewColumn2
			tileViewItemElement2.Text = "tileViewColumn2"
			tileViewItemElement3.Column = Me.tileViewColumn3
			tileViewItemElement3.Text = "tileViewColumn3"
			tileViewItemElement4.Column = Me.tileViewColumn4
			tileViewItemElement4.Text = "tileViewColumn4"
			Me.tileView1.TileTemplate.Add(tileViewItemElement1)
			Me.tileView1.TileTemplate.Add(tileViewItemElement2)
			Me.tileView1.TileTemplate.Add(tileViewItemElement3)
			Me.tileView1.TileTemplate.Add(tileViewItemElement4)
			' 
			' gridControl2
			' 
			Me.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl2.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
			Me.gridControl2.Location = New System.Drawing.Point(0, 0)
			Me.gridControl2.MainView = Me.gridView2
			Me.gridControl2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
			Me.gridControl2.Name = "gridControl2"
			Me.gridControl2.Size = New System.Drawing.Size(528, 374)
			Me.gridControl2.TabIndex = 1
			Me.gridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView2})
			' 
			' gridView2
			' 
			Me.behaviorManager1.SetBehaviors(Me.gridView2, New DevExpress.Utils.Behaviors.Behavior() { (CType(DevExpress.Utils.DragDrop.DragDropBehavior.Create(GetType(DevExpress.XtraGrid.Extensions.ColumnViewDragDropSource), True, True, True, True, Me.dragDropEvents2), DevExpress.Utils.Behaviors.Behavior))})
			Me.gridView2.DetailHeight = 284
			Me.gridView2.GridControl = Me.gridControl2
			Me.gridView2.Name = "gridView2"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(1066, 374)
			Me.Controls.Add(Me.splitContainerControl1)
			Me.Margin = New System.Windows.Forms.Padding(2)
			Me.Name = "Form1"
			Me.Text = "DragDropBetweenGridViewAndTileView"
			CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.splitContainerControl1.ResumeLayout(False)
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.tileView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridControl2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.behaviorManager1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private splitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private tileView1 As DevExpress.XtraGrid.Views.Tile.TileView
		Private gridControl2 As DevExpress.XtraGrid.GridControl
		Private gridView2 As DevExpress.XtraGrid.Views.Grid.GridView
		Private tileViewColumn1 As DevExpress.XtraGrid.Columns.TileViewColumn
		Private tileViewColumn2 As DevExpress.XtraGrid.Columns.TileViewColumn
		Private tileViewColumn3 As DevExpress.XtraGrid.Columns.TileViewColumn
		Private tileViewColumn4 As DevExpress.XtraGrid.Columns.TileViewColumn
		Private behaviorManager1 As DevExpress.Utils.Behaviors.BehaviorManager
		Private dragDropEvents1 As DevExpress.Utils.DragDrop.DragDropEvents
		Private dragDropEvents2 As DevExpress.Utils.DragDrop.DragDropEvents
	End Class
End Namespace


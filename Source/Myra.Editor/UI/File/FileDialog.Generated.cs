/* Generated by Myra UI Editor at 30.08.2018 3:05:46 */
using Microsoft.Xna.Framework;
using Myra.Graphics2D.UI;

namespace Myra.Editor.UI.File
{
	partial class FileDialog
	{
		private void BuildUI()
		{
			_buttonBack = new ImageButton();
			_buttonBack.ImageVisible = true;
			_buttonBack.ContentHorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Center;
			_buttonBack.ContentVerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Center;
			_buttonBack.Id = "_buttonBack";
			_buttonBack.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Center;
			_buttonBack.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Center;

			_buttonForward = new ImageButton();
			_buttonForward.ImageVisible = true;
			_buttonForward.ContentHorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Center;
			_buttonForward.ContentVerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Center;
			_buttonForward.Id = "_buttonForward";
			_buttonForward.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Center;
			_buttonForward.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Center;
			_buttonForward.GridPositionX = 1;

			_textFieldPath = new TextField();
			_textFieldPath.Text = "";
			_textFieldPath.Readonly = true;
			_textFieldPath.Id = "_textFieldPath";
			_textFieldPath.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Stretch;
			_textFieldPath.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Center;
			_textFieldPath.GridPositionX = 2;
			_textFieldPath.ClipToBounds = true;
			_textFieldPath.CanFocus = true;

			_buttonParent = new ImageButton();
			_buttonParent.ImageVisible = true;
			_buttonParent.ContentHorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Center;
			_buttonParent.ContentVerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Center;
			_buttonParent.Id = "_buttonParent";
			_buttonParent.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Center;
			_buttonParent.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Center;
			_buttonParent.GridPositionX = 3;

			var grid1 = new Grid();
			grid1.DrawLinesColor = Color.White;
			grid1.ColumnSpacing = 4;
			grid1.ColumnsProportions.Add(new Grid.Proportion());
			grid1.ColumnsProportions.Add(new Grid.Proportion());
			grid1.ColumnsProportions.Add(new Grid.Proportion
			{
				Type = Myra.Graphics2D.UI.Grid.ProportionType.Fill,
			});
			grid1.ColumnsProportions.Add(new Grid.Proportion());
			grid1.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Stretch;
			grid1.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Stretch;
			grid1.Widgets.Add(_buttonBack);
			grid1.Widgets.Add(_buttonForward);
			grid1.Widgets.Add(_textFieldPath);
			grid1.Widgets.Add(_buttonParent);

			_listBoxPlaces = new ListBox();
			_listBoxPlaces.DrawLinesColor = Color.White;
			_listBoxPlaces.Id = "_listBoxPlaces";
			_listBoxPlaces.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Stretch;
			_listBoxPlaces.ClipToBounds = true;

			_gridFiles = new Grid();
			_gridFiles.DrawLinesColor = Color.White;
			_gridFiles.ColumnSpacing = 4;
			_gridFiles.RowSpacing = 4;
			_gridFiles.ColumnsProportions.Add(new Grid.Proportion());
			_gridFiles.ColumnsProportions.Add(new Grid.Proportion
			{
				Type = Myra.Graphics2D.UI.Grid.ProportionType.Fill,
			});
			_gridFiles.EnableRowSelection = true;
			_gridFiles.Id = "_gridFiles";
			_gridFiles.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Stretch;
			_gridFiles.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Stretch;
			_gridFiles.CanFocus = true;

			_scrollPane = new ScrollPane();
			_scrollPane.AllowHorizontalScrolling = false;
			_scrollPane.Id = "_scrollPane";
			_scrollPane.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Stretch;
			_scrollPane.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Stretch;
			_scrollPane.GridPositionX = 2;
			_scrollPane.ClipToBounds = true;
			_scrollPane.CanFocus = true;
			_scrollPane.Child = _gridFiles;

			_splitPane = new HorizontalSplitPane();
			_splitPane.Id = "_splitPane";
			_splitPane.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Stretch;
			_splitPane.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Stretch;
			_splitPane.GridPositionY = 1;
			_splitPane.Widgets.Add(_listBoxPlaces);
			_splitPane.Widgets.Add(_scrollPane);

			_textBlockFileName = new TextBlock();
			_textBlockFileName.Text = "File name";
			_textBlockFileName.Id = "_textBlockFileName";

			_textFieldFileName = new TextField();
			_textFieldFileName.Text = "";
			_textFieldFileName.Id = "_textFieldFileName";
			_textFieldFileName.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Stretch;
			_textFieldFileName.GridPositionX = 1;
			_textFieldFileName.ClipToBounds = true;
			_textFieldFileName.CanFocus = true;

			var grid2 = new Grid();
			grid2.DrawLinesColor = Color.White;
			grid2.ColumnSpacing = 4;
			grid2.ColumnsProportions.Add(new Grid.Proportion());
			grid2.ColumnsProportions.Add(new Grid.Proportion
			{
				Type = Myra.Graphics2D.UI.Grid.ProportionType.Fill,
			});
			grid2.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Stretch;
			grid2.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Stretch;
			grid2.GridPositionY = 2;
			grid2.Widgets.Add(_textBlockFileName);
			grid2.Widgets.Add(_textFieldFileName);

			var grid3 = new Grid();
			grid3.DrawLinesColor = Color.White;
			grid3.RowSpacing = 4;
			grid3.RowsProportions.Add(new Grid.Proportion());
			grid3.RowsProportions.Add(new Grid.Proportion
			{
				Type = Myra.Graphics2D.UI.Grid.ProportionType.Fill,
			});
			grid3.RowsProportions.Add(new Grid.Proportion());
			grid3.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Stretch;
			grid3.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Stretch;
			grid3.GridPositionY = 1;
			grid3.Widgets.Add(grid1);
			grid3.Widgets.Add(_splitPane);
			grid3.Widgets.Add(grid2);

			
			Title = "Open File...";
			TitleTextColor = Color.White;
			DrawLinesColor = Color.White;
			XHint = 141;
			YHint = 183;
			WidthHint = 600;
			HeightHint = 400;
			PaddingLeft = 5;
			PaddingRight = 5;
			PaddingTop = 5;
			PaddingBottom = 5;
			CanFocus = true;
			Content = grid3;
		}

		
		public ImageButton _buttonBack;
		public ImageButton _buttonForward;
		public TextField _textFieldPath;
		public ImageButton _buttonParent;
		public ListBox _listBoxPlaces;
		public Grid _gridFiles;
		public ScrollPane _scrollPane;
		public HorizontalSplitPane _splitPane;
		public TextBlock _textBlockFileName;
		public TextField _textFieldFileName;
	}
}

class Class1
{
	//传递源列表框中选中项到目标列表框
	private void PassOnItem(ListBox lstSource,ListBox lstDest)
	{
		string ItemSource=lstSource.SelectedItem.ToString();
		string ItemDest=lstDest.SelectedItem.ToString();
		//传递到目标	
		lstDest.Items.Add(ItemSource);
		//删除源项
		lstSource.Items.Remove(ItemSource);

	}
}


class Class1
{
	//����Դ�б����ѡ���Ŀ���б��
	private void PassOnItem(ListBox lstSource,ListBox lstDest)
	{
		string ItemSource=lstSource.SelectedItem.ToString();
		string ItemDest=lstDest.SelectedItem.ToString();
		//���ݵ�Ŀ��	
		lstDest.Items.Add(ItemSource);
		//ɾ��Դ��
		lstSource.Items.Remove(ItemSource);

	}
}

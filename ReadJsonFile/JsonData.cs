namespace ReadJsonFile
{
    public class JsonData : IMenu
    {
        public MenuList[] Menus { get; set; }

        public JsonData(MenuList[] list)
        {
            Menus = list;
        }

        public int LabelSum(MenuEntry entry)
        {
            int sum = 0;
            if (entry != null)
            {
                foreach (var item in entry.Items)
                {
                    if (item?.Label != null)
                    {
                        sum += item.Id;
                    }
                }
            }
            return sum;
        }
    }
}
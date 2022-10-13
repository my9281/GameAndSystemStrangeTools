using Game;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            LoadByBin();

        }
        static void LoadByBin()
        {
            if (File.Exists(@"Save001.save"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fileStream = File.Open(@"Save001.save", FileMode.Open);
                var save = bf.Deserialize(fileStream) as PlayerDataTree;
                FileStream fileStream2 = File.Create(@"Save001.save.bak");
                bf.Serialize(fileStream2, save);
                fileStream2.Close();

                save.Gold = 999999;

                save.战斗胜利次数 = 10;
                List<int> equipli = new List<int>() {71000005,71000010,71000015,71000020,71000025,71000026,71000027,71000028,71000029,71000030,71000031,71000032,71000033,71000034,71000035,71000036,71000037, 72000005, 72000010, 72000015, 72000020, 72000025,72000030, 72000031, 72000032, 72000033, 72000034, 72000035, 72000036, 72000037,
                 72000038, 72000039, 72000040, 72000041, 72000042,73000005,73000010,73000015,73000020,73000025,73000030, 73000031, 73000032, 73000033, 73000034, 73000035, 73000036, 73000037,
                 73000038, 73000039, 73000040, 73000041, 73000042,74000005,74000010,74000015,74000020,74000025,74000030,74000035,74000040};

                save.PlayerPageDataList = new List<PlayerPageData>();
                //for (int i = 0; i < 49; i++)
                //{
                //    save.PlayerPageDataList.Add(new PlayerPageData() { Id = 510087001 + i, Num = 10, Point_PageNew = false, StoreType = StoreType.书页 });
                //}
                foreach (var item in save.PlayerBookDataList)
                {
                    item.Level = 10;
                }
                Console.WriteLine("=======================");
                save.PlayerEquipDataList = new List<PlayerEquipData>();
                for (int j = 0; j < 1; j++)
                {
                    foreach (var item in equipli)
                    {
                        save.PlayerEquipDataList.Add(new PlayerEquipData() { Id = item, Point_EquipNew = false, StoreType = StoreType.装备, Level = 3, Num = 1 });
                    }
                    for (int i = 40; i < 51; i++)
                    {
                        save.PlayerEquipDataList.Add(new PlayerEquipData() { Id = 74000000 + i + 1, Point_EquipNew = false, StoreType = StoreType.装备, Level = 3, Num = 1 });
                    }
                }

                foreach (var item in save.PlayerHeroDataList)
                {
                    foreach (var item2 in item.ActiveSkill)
                    {

                        if (item2 != null)
                        {
                            item2.Level = 3;
                        }
                    }
                    foreach (var item2 in item.ActiveSelectSkill)
                    {
                        if (item2!=null)
                        { 
                            item2.Level = 3;
                        }
                    }
                    item.IdleSkill.Level = 3;
                    foreach (var item2 in item.TalentSkill)
                    {

                        if (item2 != null)
                        {
                            item2.Level = 3;
                        }
                    }  
                    foreach (var item2 in item.TalentSelectSkill)
                    {
                        if (item2 != null)
                        {
                            item2.Level = 3;
                        }
                    }
                    foreach (var item2 in item.MapSelectSkill)
                    {
                        item2.Level = 3;
                    }
                    foreach (var item2 in item.MapSkill)
                    {
                        if (item2 != null)
                        {
                            item2.Level = 3;
                        }
                    }
                    item.MaxHp= 5000;
                    item.CurrentHp = 5000; 
                }
                foreach (var item in save.PlayerEquipDataList)
                {
                    Console.WriteLine(item.Id);
                }
                foreach (var item in save.PlayerEquipDataList)
                {
                    Console.WriteLine(item.Id);
                }
                foreach (var item in save.PlayerRuneDataList)
                {
                    item.PlayerRuneState = PlayerRuneState.未装备;
                }
                foreach (var item in save.PlayerBuildingDataList)
                {
                    item.PlayerBuildingState = PlayerBuildingState.已出现;
                }
                Console.WriteLine("");
                //save.PlayerUpItemDataList = new List<PlayerUpItemData>();
                //for (int i = 51069001; i < 51090001; i += 1000)
                //{
                //    save.PlayerUpItemDataList.Add(new PlayerUpItemData() { Id = i, Num = 999, Point_UpItemNew = true, StoreType = Game.StoreType.装备强化 });
                //}


                //foreach (var item in save.PlayerHeroDataList)
                //{
                //     var equiplist = new List<PlayerEquipData>();
                //    foreach (var item2 in item.Equip)
                //    {
                //        var ii = new PlayerEquipData() { Id = item2.Id, Level = item2.Level, Num = item2.Num, Point_EquipNew = false, StoreType = StoreType.装备 };
                //        equiplist.Add(ii);
                //    }
                //    item.Equip = equiplist.ToArray();
                //}

                //foreach (var item in save.PlayerTaskDataList)
                //{
                //    if (item.Id == 6)
                //    {
                //        item.PlayerTaskState = PlayerTaskState.已完成;

                //    }
                //}

                FileStream fileStream3 = File.Create(@"Save002.save");
                bf.Serialize(fileStream3, save);
                fileStream2.Close();
                //关闭文件流
                fileStream.Close();
            }
            else
            {
            }
        }
        static void SaveByBin()
        {
        }
    }
}

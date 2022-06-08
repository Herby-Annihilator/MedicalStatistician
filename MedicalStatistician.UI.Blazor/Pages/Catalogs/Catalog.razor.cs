using MedicalStatistician.DAL.Entities.Base;
using MedicalStatistician.DAL.Repositories.Base;
using Microsoft.AspNetCore.Components;

namespace MedicalStatistician.UI.Blazor.Pages.Catalogs
{
    public partial class Catalog<TCatalog> where TCatalog : NamedEntity, new()
    {
        [Parameter]
        public ICrudRepository<TCatalog> Repository { get; set; }
               
        private IList<TCatalog> Collection;

        protected override async Task OnInitializedAsync()
        {
            Collection = (await Repository.GetAllAsync()).ToList();
        }
        //
        // CRUD методы
        //
        public void Create()
        {
            ModalWindow.Title = "Добавление данных";
            ModalWindow.SaveButtonName = "Добавить";           
            ModalWindow.Open();
        }

        public void Update(TCatalog item)
        {
            itemToUpdate = item;
            ModalWindow.Title = "Изменение данных";
            ModalWindow.SaveButtonName = "Изменить";
            ModalWindow.Open();
        }

        public async Task Delete(TCatalog item)
        {
            if (Collection != null)
            {
                Collection.Remove(item);
                await Repository.DeleteAsync(item);
            }
            
        }
        //
        // Методы работы с модальным окном
        //
        Modal.ModalCreateUpdateCatalog ModalWindow;
        private TCatalog itemToUpdate;

        private async Task Save()
        {
            if (ModalWindow.ItemName != "")
            {
                switch(ModalWindow.SaveButtonName)
                {
                    case "Добавить": await OnCreate(ModalWindow.ItemName);
                        break;
                    case "Изменить": await OnUpdate(ModalWindow.ItemName);
                        break;
                    default:
                        break;
                }
            }
        }

        private async Task OnCreate(string itemName)
        {
            TCatalog entity = new();
            entity.Name = itemName;
            entity = await Repository.CreateAsync(entity);
            if (entity is not null)
                Collection.Add(entity);
            ModalWindow.Close();
        }

        private async Task OnUpdate(string itemName)
        {
            if (itemToUpdate is not null)
            {
                itemToUpdate.Name = itemName;
                await Repository.UpdateAsync(itemToUpdate);
            }
            ModalWindow.Close();
        }

    }
}

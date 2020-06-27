using Core.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Service
{
    public interface IService <Search,CreateModel>
    {
        IRequestResult GetAll();
        IRequestResult Create(CreateModel model);
        IRequestResult Delete(int id);
    }
}

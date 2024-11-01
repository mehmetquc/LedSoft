﻿using Blazored.Modal.Services;
using Blazored.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LedSoft.mobile.Components.ModalComponents;

namespace LedSoft.mobile.Utils
{
    public class ModalManager
    {
        private readonly IModalService modalService;

        public ModalManager(IModalService ModalService)
        {
            modalService = ModalService;
        }




        public async Task ShowMessageAsync(String Title, String Message, int Duration = 0)
        {
            ModalParameters mParams = new ModalParameters();
            mParams.Add("Message", Message);

            var modalRef = modalService.Show<ShowMessagePopupComponent>(Title, mParams);

            if (Duration > 0)
            {
                await Task.Delay(Duration);
                modalRef.Close();
            }
        }

        public async Task<bool> ConfirmationAsync(String Title, String Message)
        {
            ModalParameters mParams = new ModalParameters();
            mParams.Add("Message", Message);

            var modalRef = modalService.Show<ConfirmationPopupComponent>(Title, mParams);
            var modalResult = await modalRef.Result;

            return !modalResult.Cancelled;
        }


    }
}

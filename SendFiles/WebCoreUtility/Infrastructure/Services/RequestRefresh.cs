﻿using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Infrastructure.Services.Interfaces;

namespace CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Infrastructure.Services
{
    /// <summary>
    /// Service to trigger a refresh in one component from another.
    /// </summary>
    public class RequestRefresh : IRequestRefresh
    {
        #region Events

        /// <summary>
        /// Event triggered when a refresh is requested.
        /// </summary>
        public event Action? RefreshRequested;

        #endregion

        #region Public Methods

        /// <summary>
        /// Invokes the RefreshRequested event to trigger a refresh.
        /// </summary>
        public void CallRequestRefresh()
        {
            RefreshRequested?.Invoke();
        }

        #endregion
    }
}
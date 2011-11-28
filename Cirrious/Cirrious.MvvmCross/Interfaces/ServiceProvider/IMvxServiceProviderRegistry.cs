#region Copyright
// <copyright file="IMvxServiceProviderRegistry.cs" company="Cirrious">
// (c) Copyright Cirrious. http://www.cirrious.com
// This source is subject to the Microsoft Public License (Ms-PL)
// Please see license.txt on http://opensource.org/licenses/ms-pl.html
// All other rights reserved.
// </copyright>
// 
// Author - Stuart Lodge, Cirrious. http://www.cirrious.com
#endregion
namespace Cirrious.MvvmCross.Interfaces.ServiceProvider
{
    public interface IMvxServiceProviderRegistry : IMvxServiceProvider
    {
        void RegisterServiceType<TFrom, TTo>();
        void RegisterServiceInstance<TInterface>(TInterface theObject);
    }
}
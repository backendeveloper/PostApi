﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Common {
    using System;
    using System.Reflection;
    
    
    /// <summary>
    ///    A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Messages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        internal Messages() {
        }
        
        /// <summary>
        ///    Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Common.Messages", typeof(Messages).GetTypeInfo().Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///    Overrides the current thread's CurrentUICulture property for all
        ///    resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Butik bulunamadı.
        /// </summary>
        public static string BoutiqueDetail_BoutiqueNotFound1 {
            get {
                return ResourceManager.GetString("BoutiqueDetail_BoutiqueNotFound1", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Butik detay için boş filtre girilemez.
        /// </summary>
        public static string BoutiqueDetailFilterNullError1 {
            get {
                return ResourceManager.GetString("BoutiqueDetailFilterNullError1", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Butik Id&apos;si 1&apos;den küçük olamaz.
        /// </summary>
        public static string BoutiqueDetailMinBoutiqueIdError1 {
            get {
                return ResourceManager.GetString("BoutiqueDetailMinBoutiqueIdError1", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Butik bulunamadı.
        /// </summary>
        public static string BoutiqueList_BoutiqueNotFound1 {
            get {
                return ResourceManager.GetString("BoutiqueList_BoutiqueNotFound1", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Favori ürün bulunamadı.
        /// </summary>
        public static string FavoriteProductList_ProductNotFound1 {
            get {
                return ResourceManager.GetString("FavoriteProductList_ProductNotFound1", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Bilgi bandı bulunamadı.
        /// </summary>
        public static string MobileBandInfo_InfoNotFound {
            get {
                return ResourceManager.GetString("MobileBandInfo_InfoNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Sayfa numarası birden küçük olamaz.
        /// </summary>
        public static string PaginationMinLengthError1 {
            get {
                return ResourceManager.GetString("PaginationMinLengthError1", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Butik id 1 den büyük olmalıdır.
        /// </summary>
        public static string ProductDetail_BoutiqueIdMustBeGreaterThanDefault1 {
            get {
                return ResourceManager.GetString("ProductDetail_BoutiqueIdMustBeGreaterThanDefault1", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Ürün id 1 den büyük olmalıdır.
        /// </summary>
        public static string ProductDetail_ProductIdMustBeGreaterThanDefault1 {
            get {
                return ResourceManager.GetString("ProductDetail_ProductIdMustBeGreaterThanDefault1", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Ürün bulunamadı.
        /// </summary>
        public static string ProductDetail_ProductNotFound1 {
            get {
                return ResourceManager.GetString("ProductDetail_ProductNotFound1", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to İşlem sırasında beklenmeyen bir hata oluştu.
        /// </summary>
        public static string UnhandledExceptionMessage1 {
            get {
                return ResourceManager.GetString("UnhandledExceptionMessage1", resourceCulture);
            }
        }
    }
}

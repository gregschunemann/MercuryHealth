// <assemblyHash>887907d5</assemblyHash>
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
//
//     This source code was auto-generated by Microsoft.QualityTools.Testing.Fakes, Version=15.0.0.0.
// </auto-generated>
#pragma warning disable 0067, 0108, 0618
#line hidden
extern alias mhm;
extern alias mhw;
extern alias mqttf;

[assembly: mqttf::Microsoft.QualityTools.Testing.Fakes.FakesAssembly("MercuryHealth.Web", false)]
[assembly: global::System.Reflection.AssemblyCompany("")]
[assembly: global::System.Reflection.AssemblyConfiguration("")]
[assembly: global::System.Reflection.AssemblyFileVersion("1.3.0.0")]
[assembly: global::System.Reflection.AssemblyProduct("MercuryHealth.Web")]
[assembly: global::System.Reflection.AssemblyVersion("1.3.6578.29145")]
[assembly: global::System.Runtime.CompilerServices.InternalsVisibleTo("MercuryHealth.Web.Explorables")]
[assembly: global::System.Runtime.CompilerServices.InternalsVisibleTo("MercuryHealth.Web.Tests")]
namespace MercuryHealth.Web.Models.Fakes
{
    /// <summary>Stub type of MercuryHealth.Web.Models.IFoodLogEntryRepository</summary>
    [mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.StubClass(typeof(mhw::MercuryHealth.Web.Models.IFoodLogEntryRepository))]
    [global::System.Diagnostics.DebuggerDisplay("Stub of IFoodLogEntryRepository")]
    [global::System.Diagnostics.DebuggerNonUserCode]
    public partial class StubIFoodLogEntryRepository
      : mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.StubBase<mhw::MercuryHealth.Web.Models.IFoodLogEntryRepository>
      , mhw::MercuryHealth.Web.Models.IFoodLogEntryRepository
    {
        /// <summary>Initializes a new instance of type StubIFoodLogEntryRepository</summary>
        public StubIFoodLogEntryRepository()
        {
        }

        /// <summary>Sets the stub of IFoodLogEntryRepository.Create(FoodLogEntry newFoodLogEntry)</summary>
        public mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Action<mhm::MercuryHealth.Models.FoodLogEntry> CreateFoodLogEntry;

        /// <summary>Sets the stub of IFoodLogEntryRepository.Delete(Int32 id)</summary>
        public mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Action<int> DeleteInt32;

        /// <summary>Sets the stub of IFoodLogEntryRepository.GetAll()</summary>
        public mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Func<global::System.Linq.IQueryable<mhm::MercuryHealth.Models.FoodLogEntry>> GetAll;

        /// <summary>Sets the stub of IFoodLogEntryRepository.Get(Nullable`1&lt;Int32&gt; id)</summary>
        public mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Func<int?, mhm::MercuryHealth.Models.FoodLogEntry> GetNullableOfInt32;

        /// <summary>Sets the stub of IFoodLogEntryRepository.Create(FoodLogEntry newFoodLogEntry)</summary>
        void mhw::MercuryHealth.Web.Models.IFoodLogEntryRepository.Create(mhm::MercuryHealth.Models.FoodLogEntry newFoodLogEntry)
        {
            mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStubObserver ___observer
               = ((mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStubObservable)this).InstanceObserver;
            if ((object)___observer != (object)null)
            {
              mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Action<mhm::MercuryHealth.Models.FoodLogEntry> ___currentMethod
                 = ((mhw::MercuryHealth.Web.Models.IFoodLogEntryRepository)this).Create;
              ___observer.Enter
                  (typeof(mhw::MercuryHealth.Web.Models.IFoodLogEntryRepository), (global::System.Delegate)___currentMethod, (object)newFoodLogEntry);
            }
            mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Action<mhm::MercuryHealth.Models.FoodLogEntry> ___sh = this.CreateFoodLogEntry;
            if ((object)___sh != (object)null)
              ___sh.Invoke(newFoodLogEntry);
            else 
            {
              mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStubBehavior ___behavior
                 = ((mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStub)this).InstanceBehavior;
              ___behavior.VoidResult<global::MercuryHealth.Web.Models.Fakes.StubIFoodLogEntryRepository>
                  (this, "MercuryHealth.Web.Models.IFoodLogEntryRepository.Create");
            }
        }

        /// <summary>Sets the stub of IFoodLogEntryRepository.Delete(Int32 id)</summary>
        void mhw::MercuryHealth.Web.Models.IFoodLogEntryRepository.Delete(int id)
        {
            mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStubObserver ___observer
               = ((mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStubObservable)this).InstanceObserver;
            if ((object)___observer != (object)null)
            {
              mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Action<int> ___currentMethod
                 = ((mhw::MercuryHealth.Web.Models.IFoodLogEntryRepository)this).Delete;
              ___observer.Enter(typeof(mhw::MercuryHealth.Web.Models.IFoodLogEntryRepository), (global::System.Delegate)___currentMethod, (object)id);
            }
            mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Action<int> ___sh = this.DeleteInt32;
            if ((object)___sh != (object)null)
              ___sh.Invoke(id);
            else 
            {
              mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStubBehavior ___behavior
                 = ((mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStub)this).InstanceBehavior;
              ___behavior.VoidResult<global::MercuryHealth.Web.Models.Fakes.StubIFoodLogEntryRepository>
                  (this, "MercuryHealth.Web.Models.IFoodLogEntryRepository.Delete");
            }
        }

        /// <summary>Sets the stub of IFoodLogEntryRepository.Get(Nullable`1&lt;Int32&gt; id)</summary>
        mhm::MercuryHealth.Models.FoodLogEntry mhw::MercuryHealth.Web.Models.IFoodLogEntryRepository.Get(int? id)
        {
            mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStubObserver ___observer
               = ((mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStubObservable)this).InstanceObserver;
            if ((object)___observer != (object)null)
            {
              mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Func<int?, mhm::MercuryHealth.Models.FoodLogEntry> ___currentMethod
                 = ((mhw::MercuryHealth.Web.Models.IFoodLogEntryRepository)this).Get;
              ___observer.Enter(typeof(mhw::MercuryHealth.Web.Models.IFoodLogEntryRepository), (global::System.Delegate)___currentMethod, (object)id);
            }
            mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Func<int?, mhm::MercuryHealth.Models.FoodLogEntry> ___sh
               = this.GetNullableOfInt32;
            if ((object)___sh != (object)null)
              return ___sh.Invoke(id);
            else 
            {
              mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStubBehavior ___behavior
                 = ((mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStub)this).InstanceBehavior;
              return ___behavior.Result<global::MercuryHealth.Web.Models.Fakes.StubIFoodLogEntryRepository, mhm::MercuryHealth.Models.FoodLogEntry>
                         (this, "MercuryHealth.Web.Models.IFoodLogEntryRepository.Get");
            }
        }

        /// <summary>Sets the stub of IFoodLogEntryRepository.GetAll()</summary>
        global::System.Linq.IQueryable<mhm::MercuryHealth.Models.FoodLogEntry> mhw::MercuryHealth.Web.Models.IFoodLogEntryRepository.GetAll()
        {
            mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStubObserver ___observer
               = ((mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStubObservable)this).InstanceObserver;
            if ((object)___observer != (object)null)
            {
              mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Func<global::System.Linq.IQueryable<mhm::MercuryHealth.Models.FoodLogEntry>> 
                ___currentMethod = ((mhw::MercuryHealth.Web.Models.IFoodLogEntryRepository)this).GetAll;
              ___observer.Enter(typeof(mhw::MercuryHealth.Web.Models.IFoodLogEntryRepository), (global::System.Delegate)___currentMethod);
            }
            mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Func<global::System.Linq.IQueryable<mhm::MercuryHealth.Models.FoodLogEntry>> 
              ___sh = this.GetAll;
            if ((object)___sh != (object)null)
              return ___sh.Invoke();
            else 
            {
              mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStubBehavior ___behavior
                 = ((mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStub)this).InstanceBehavior;
              return ___behavior.Result<global::MercuryHealth.Web.Models.Fakes.StubIFoodLogEntryRepository, 
                                        global::System.Linq.IQueryable<mhm::MercuryHealth.Models.FoodLogEntry>>(this, "MercuryHealth.Web.Models.IFoodLogEntryRepository.GetAll");
            }
        }

        /// <summary>Sets the stub of IFoodLogEntryRepository.Update(FoodLogEntry updatedFoodLogEntry)</summary>
        void mhw::MercuryHealth.Web.Models.IFoodLogEntryRepository.Update(mhm::MercuryHealth.Models.FoodLogEntry updatedFoodLogEntry)
        {
            mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStubObserver ___observer
               = ((mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStubObservable)this).InstanceObserver;
            if ((object)___observer != (object)null)
            {
              mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Action<mhm::MercuryHealth.Models.FoodLogEntry> ___currentMethod
                 = ((mhw::MercuryHealth.Web.Models.IFoodLogEntryRepository)this).Update;
              ___observer.Enter
                  (typeof(mhw::MercuryHealth.Web.Models.IFoodLogEntryRepository), (global::System.Delegate)___currentMethod, (object)updatedFoodLogEntry);
            }
            mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Action<mhm::MercuryHealth.Models.FoodLogEntry> ___sh = this.UpdateFoodLogEntry;
            if ((object)___sh != (object)null)
              ___sh.Invoke(updatedFoodLogEntry);
            else 
            {
              mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStubBehavior ___behavior
                 = ((mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStub)this).InstanceBehavior;
              ___behavior.VoidResult<global::MercuryHealth.Web.Models.Fakes.StubIFoodLogEntryRepository>
                  (this, "MercuryHealth.Web.Models.IFoodLogEntryRepository.Update");
            }
        }

        /// <summary>Sets the stub of IFoodLogEntryRepository.Update(FoodLogEntry updatedFoodLogEntry)</summary>
        public mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Action<mhm::MercuryHealth.Models.FoodLogEntry> UpdateFoodLogEntry;
    }
}
namespace MercuryHealth.Web.Utilities.Fakes
{
    /// <summary>Shim type of MercuryHealth.Web.Utilities.UserRepository</summary>
    [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimClass(typeof(mhw::MercuryHealth.Web.Utilities.UserRepository))]
    [global::System.Diagnostics.DebuggerDisplay("Shim of UserRepository")]
    [global::System.Diagnostics.DebuggerNonUserCode]
    public partial class ShimUserRepository
      : mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimBase<mhw::MercuryHealth.Web.Utilities.UserRepository>
    {
        /// <summary>Initializes a new shim instance</summary>
        public ShimUserRepository()
        : base()
        {
        }

        /// <summary>Initializes a new shim for the given instance</summary>
        public ShimUserRepository(mhw::MercuryHealth.Web.Utilities.UserRepository instance)
        : base(instance)
        {
        }

        /// <summary>Define shims for all instances members</summary>
        public static partial class AllInstances
        {
            /// <summary>Sets the shim of UserRepository.GetUser(Int32 userId)</summary>
            public static mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Func<mhw::MercuryHealth.Web.Utilities.UserRepository, int, mhw::MercuryHealth.Web.Utilities.User> GetUserInt32
            {
                [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimMethod("GetUser", 20)]
                set
                {
                    mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime.SetShimPublicInstance
                        ((global::System.Delegate)value, typeof(mhw::MercuryHealth.Web.Utilities.UserRepository), (object)null, 
                         "GetUser", typeof(mhw::MercuryHealth.Web.Utilities.User), new global::System.Type[]{typeof(int)});
                }
            }
        }

        /// <summary>Assigns the &apos;Current&apos; behavior for all methods of the shimmed type</summary>
        public static void BehaveAsCurrent()
        {
            global::MercuryHealth.Web.Utilities.Fakes.ShimUserRepository.Behavior =
              mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimBehaviors.CurrentProxy;
        }

        /// <summary>Assigns the &apos;NotImplemented&apos; behavior for all methods of the shimmed type</summary>
        public static void BehaveAsNotImplemented()
        {
            global::MercuryHealth.Web.Utilities.Fakes.ShimUserRepository.Behavior =
              mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimBehaviors.NotImplemented;
        }

        /// <summary>Assigns the behavior for all methods of the shimmed type</summary>
        public static mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.IShimBehavior Behavior
        {
            set
            {
                mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimBehaviors.AttachToType(typeof(mhw::MercuryHealth.Web.Utilities.UserRepository), value);
            }
        }

        /// <summary>Sets the shim of UserRepository.UserRepository()</summary>
        public static mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Action<mhw::MercuryHealth.Web.Utilities.UserRepository> Constructor
        {
            [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimMethod(".ctor", 20)]
            set
            {
                mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime.SetShimPublicInstance
                    ((global::System.Delegate)value, typeof(mhw::MercuryHealth.Web.Utilities.UserRepository), (object)null, 
                     ".ctor", typeof(void), new global::System.Type[]{});
            }
        }

        /// <summary>Sets the shim of UserRepository.GetUser(Int32 userId)</summary>
        public mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Func<int, mhw::MercuryHealth.Web.Utilities.User> GetUserInt32
        {
            [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimMethod("GetUser", 20)]
            set
            {
                mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime.SetShimPublicInstance
                    ((global::System.Delegate)(mqttf::Microsoft.QualityTools.Testing.Fakes.FakesExtensions
                                                 .Uncurrify<mhw::MercuryHealth.Web.Utilities.UserRepository, int, mhw::MercuryHealth.Web.Utilities.User>(value)), 
                     typeof(mhw::MercuryHealth.Web.Utilities.UserRepository), base.Instance, 
                     "GetUser", typeof(mhw::MercuryHealth.Web.Utilities.User), new global::System.Type[]{typeof(int)});
            }
        }
    }
}

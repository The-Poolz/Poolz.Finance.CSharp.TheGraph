# Poolz.Finance.CSharp.TheGraph

Auto-generated C# GraphQL client for TheGraph of The-Poolz company.

## ⚙️ CI / CD Workflows

### **📈 Version bump**

**How to trigger**: Open an issue titled **`Bump version to X.Y.Z`**

**What happens**: A workflow updates the `<Version>` element in the `.csproj`, commits the change, and opens a pull request.

---

### **⚡ Code generation**

**How to trigger**: Open an issue titled **`Codegen`**

**What happens**: The workflow fetches the latest TheGraph schema, regenerates the C# with [GraphQlClientGenerator.Tool](https://github.com/Husqvik/GraphQlClientGenerator), commits the change, and opens a pull request.

---

### **🚀 NuGet publish**

**How to trigger**: Create a GitHub _release_ (tagged **`vX.Y.Z`**)

**What happens**: After the version-bump PR is merged, the release workflow builds the package and pushes it to [NuGet](www.nuget.org/packages/Poolz.Finance.CSharp.TheGraph).

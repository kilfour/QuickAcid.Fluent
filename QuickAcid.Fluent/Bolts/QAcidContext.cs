namespace QuickAcid.Fluent.Bolts;

public interface QAcidContext
{
    T Get<T>(QKey<T> key);
    T GetItAtYourOwnRisk<T>(string label);
}
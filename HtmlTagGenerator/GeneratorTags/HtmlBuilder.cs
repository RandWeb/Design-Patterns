﻿namespace Creational.Builder.HtmlTagAndPersonBuilder.GeneratorTags;

class HtmlBuilder
{
    private readonly string _rootName;
    private HtmlElement _root;
    public HtmlBuilder(string rootName)
    {
        _rootName = rootName;
        _root = new HtmlElement(rootName);
    }

    // not fluent
    public void AddChild(string childName, string childText)
    {
        var e = new HtmlElement(childName, childText);
        _root.Elements.Add(e);
    }

    public HtmlBuilder AddChildFluent(string childName, string childText)
    {
        var e = new HtmlElement(childName, childText);
        _root.Elements.Add(e);
        return this;
    }

    public override string ToString()
    {
        return _root.ToString();
    }

    public void Clear()
    {
        _root = new HtmlElement(_rootName);
    }

}
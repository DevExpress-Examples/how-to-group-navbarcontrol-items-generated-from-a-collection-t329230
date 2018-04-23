# How to group NavBarControl items generated from a collection


<p>In this example, it's demonstrated how to use the <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfNavBarNavBarControl_GroupDescriptiontopic">GroupDescription</a> property to automatically group items generated from a collection. To accomplish this task, it's necessary to set GroupDescription to a property name by which items should be grouped.</p>
<p><br>Another solution to group items is to bind NavBarControl to a source that implements ICollectionView and specify GroupDescriptions:</p>


```cs
CollectionViewEmployees.GroupDescriptions.Add(new PropertyGroupDescription("Department"));
```


<p> </p>
<p>If you wish to specify ItemsSource for each group separately, use the approach demonstrated at <a href="https://www.devexpress.com/Support/Center/p/E3521">How to: Generate NavBarControl Groups and Items from a Collection</a></p>

<br/>



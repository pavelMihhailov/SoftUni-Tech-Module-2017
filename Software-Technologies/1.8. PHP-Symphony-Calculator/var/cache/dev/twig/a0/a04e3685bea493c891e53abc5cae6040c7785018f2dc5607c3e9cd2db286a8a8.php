<?php

/* form/fields.html.twig */
class __TwigTemplate_4172a7ef08a548b13ea918215f030723e899c5febd503ffc27e37dc9f11dc3ca extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        $this->parent = false;

        $this->blocks = array(
            'date_time_picker_widget' => array($this, 'block_date_time_picker_widget'),
        );
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_44ab97deee0f7fc76a3c44a3554a3d365e2e39ff671f1b667ef75a241ed137cc = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_44ab97deee0f7fc76a3c44a3554a3d365e2e39ff671f1b667ef75a241ed137cc->enter($__internal_44ab97deee0f7fc76a3c44a3554a3d365e2e39ff671f1b667ef75a241ed137cc_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "form/fields.html.twig"));

        // line 9
        echo "
";
        // line 10
        $this->displayBlock('date_time_picker_widget', $context, $blocks);
        
        $__internal_44ab97deee0f7fc76a3c44a3554a3d365e2e39ff671f1b667ef75a241ed137cc->leave($__internal_44ab97deee0f7fc76a3c44a3554a3d365e2e39ff671f1b667ef75a241ed137cc_prof);

    }

    public function block_date_time_picker_widget($context, array $blocks = array())
    {
        $__internal_5f0d9bc21b6634e81e914cca3c70f0e378862bf86fa2a7f2dacc286aa7975074 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_5f0d9bc21b6634e81e914cca3c70f0e378862bf86fa2a7f2dacc286aa7975074->enter($__internal_5f0d9bc21b6634e81e914cca3c70f0e378862bf86fa2a7f2dacc286aa7975074_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "date_time_picker_widget"));

        // line 11
        echo "    ";
        ob_start();
        // line 12
        echo "        <div class=\"input-group date\" data-toggle=\"datetimepicker\">
            ";
        // line 13
        $this->displayBlock("datetime_widget", $context, $blocks);
        echo "
            ";
        // line 15
        echo "                ";
        // line 16
        echo "            ";
        // line 17
        echo "        </div>
    ";
        echo trim(preg_replace('/>\s+</', '><', ob_get_clean()));
        
        $__internal_5f0d9bc21b6634e81e914cca3c70f0e378862bf86fa2a7f2dacc286aa7975074->leave($__internal_5f0d9bc21b6634e81e914cca3c70f0e378862bf86fa2a7f2dacc286aa7975074_prof);

    }

    public function getTemplateName()
    {
        return "form/fields.html.twig";
    }

    public function getDebugInfo()
    {
        return array (  52 => 17,  50 => 16,  48 => 15,  44 => 13,  41 => 12,  38 => 11,  26 => 10,  23 => 9,);
    }

    public function getSource()
    {
        return "{#
   Each field type is rendered by a template fragment, which is determined
   by the name of your form type class (DateTimePickerType -> date_time_picker)
   and the suffix \"_widget\". This can be controlled by overriding getBlockPrefix()
   in DateTimePickerType.

   See http://symfony.com/doc/current/cookbook/form/create_custom_field_type.html#creating-a-template-for-the-field
#}

{% block date_time_picker_widget %}
    {% spaceless %}
        <div class=\"input-group date\" data-toggle=\"datetimepicker\">
            {{ block('datetime_widget') }}
            {#<span class=\"input-group-addon\">#}
                {#<span class=\"fa fa-calendar\" aria-hidden=\"true\"></span>#}
            {#</span>#}
        </div>
    {% endspaceless %}
{% endblock %}
";
    }
}

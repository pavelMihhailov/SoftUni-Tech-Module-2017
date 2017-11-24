<?php

/* @WebProfiler/Collector/router.html.twig */
class __TwigTemplate_861554af81d0cfcade5d9b10ee63cdcbdb635ea764b7a922198ba9cdd1eccab0 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("@WebProfiler/Profiler/layout.html.twig", "@WebProfiler/Collector/router.html.twig", 1);
        $this->blocks = array(
            'toolbar' => array($this, 'block_toolbar'),
            'menu' => array($this, 'block_menu'),
            'panel' => array($this, 'block_panel'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "@WebProfiler/Profiler/layout.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_402834f654edda0e9c71712b4dffdfa4103cd3ceece67536a7fbea8a978af902 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_402834f654edda0e9c71712b4dffdfa4103cd3ceece67536a7fbea8a978af902->enter($__internal_402834f654edda0e9c71712b4dffdfa4103cd3ceece67536a7fbea8a978af902_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/router.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_402834f654edda0e9c71712b4dffdfa4103cd3ceece67536a7fbea8a978af902->leave($__internal_402834f654edda0e9c71712b4dffdfa4103cd3ceece67536a7fbea8a978af902_prof);

    }

    // line 3
    public function block_toolbar($context, array $blocks = array())
    {
        $__internal_e65caa2de7e6a0c870e642d09a5640e4fa682ad2df8f058cf488ec82c3588019 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_e65caa2de7e6a0c870e642d09a5640e4fa682ad2df8f058cf488ec82c3588019->enter($__internal_e65caa2de7e6a0c870e642d09a5640e4fa682ad2df8f058cf488ec82c3588019_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "toolbar"));

        
        $__internal_e65caa2de7e6a0c870e642d09a5640e4fa682ad2df8f058cf488ec82c3588019->leave($__internal_e65caa2de7e6a0c870e642d09a5640e4fa682ad2df8f058cf488ec82c3588019_prof);

    }

    // line 5
    public function block_menu($context, array $blocks = array())
    {
        $__internal_0d901d23176a30b33e89199c9693d688028167ec533d5d8c90f4c16c19fde899 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_0d901d23176a30b33e89199c9693d688028167ec533d5d8c90f4c16c19fde899->enter($__internal_0d901d23176a30b33e89199c9693d688028167ec533d5d8c90f4c16c19fde899_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "menu"));

        // line 6
        echo "<span class=\"label\">
    <span class=\"icon\">";
        // line 7
        echo twig_include($this->env, $context, "@WebProfiler/Icon/router.svg");
        echo "</span>
    <strong>Routing</strong>
</span>
";
        
        $__internal_0d901d23176a30b33e89199c9693d688028167ec533d5d8c90f4c16c19fde899->leave($__internal_0d901d23176a30b33e89199c9693d688028167ec533d5d8c90f4c16c19fde899_prof);

    }

    // line 12
    public function block_panel($context, array $blocks = array())
    {
        $__internal_306d8bc090b15bb95740ad87eaf2014f7266363b9e14b8ddcd4e529e9873cd4f = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_306d8bc090b15bb95740ad87eaf2014f7266363b9e14b8ddcd4e529e9873cd4f->enter($__internal_306d8bc090b15bb95740ad87eaf2014f7266363b9e14b8ddcd4e529e9873cd4f_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "panel"));

        // line 13
        echo "    ";
        echo $this->env->getExtension('Symfony\Bridge\Twig\Extension\HttpKernelExtension')->renderFragment($this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("_profiler_router", array("token" => (isset($context["token"]) ? $context["token"] : $this->getContext($context, "token")))));
        echo "
";
        
        $__internal_306d8bc090b15bb95740ad87eaf2014f7266363b9e14b8ddcd4e529e9873cd4f->leave($__internal_306d8bc090b15bb95740ad87eaf2014f7266363b9e14b8ddcd4e529e9873cd4f_prof);

    }

    public function getTemplateName()
    {
        return "@WebProfiler/Collector/router.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  73 => 13,  67 => 12,  56 => 7,  53 => 6,  47 => 5,  36 => 3,  11 => 1,);
    }

    public function getSource()
    {
        return "{% extends '@WebProfiler/Profiler/layout.html.twig' %}

{% block toolbar %}{% endblock %}

{% block menu %}
<span class=\"label\">
    <span class=\"icon\">{{ include('@WebProfiler/Icon/router.svg') }}</span>
    <strong>Routing</strong>
</span>
{% endblock %}

{% block panel %}
    {{ render(path('_profiler_router', { token: token })) }}
{% endblock %}
";
    }
}
